() => {
    // 1) Configuration
    const THRESHOLDS = {
        margin: 15,     // px threshold above which we clamp margins
        padding: 20,    // px threshold above which we clamp paddings
        gap: 20         // px minimum gap that triggers gap-reduction
    };

    const SPACING = {
        standard: { m: 10, p: 15, hm: 5, hp: 5 },
        elegant: { m: 5, p: 10, hm: 0, hp: 0 }
    };

    const IDENTIFIERS = ['elegant_cards'];

    // 2) Detect template type
    const isElegant = IDENTIFIERS.some(id =>
        document.body.dataset.template?.includes(id) ||
        !!document.querySelector(`link[href*="${id}"]`)
    );
    const S = isElegant ? SPACING.elegant : SPACING.standard;

    // 3) Build & inject CSS
    const css = [];

    // Header
    css.push(`
    header {
      margin-bottom: ${S.hm}px !important;
      padding-bottom: ${S.hp}px !important;
      page-break-after: avoid !important;
    }
  `);

    if (isElegant) {
        css.push(`
      .resume-body, .content-area, main {
        margin-top: -10px !important;
        padding-top: 0 !important;
        page-break-before: avoid !important;
      }
      .card, .section-card, .content-card {
        margin-bottom: 8px !important;
        page-break-inside: avoid !important;
      }
    `);
    } else {
        // standard first-section tweak
        const firsts = [
            '.main-content:first-child',
            '.section:first-child',
            'main > section:first-child',
            'main > div:first-child',
            '.container > section:first-child',
            '.container > div:first-child',
            'body > section:first-child',
            'body > div:not(header):first-of-type',
            '.cv-section:first-child'
        ];
        firsts.forEach(sel => {
            css.push(`${sel} { margin-top:5px !important; padding-top:5px !important; }`);
        });
    }

    // Global clamp & page-break rules
    css.push(`
    section, article, div, main {
      page-break-inside: avoid !important;
      margin-top:    ${S.m}px !important;
      margin-bottom: ${S.m}px !important;
      padding-top:   ${S.p}px !important;
      padding-bottom:${S.p}px !important;
    }

    img {
      max-width: 100% !important;
      height:    auto !important;
    }

    h1, h2, h3, h4, h5, h6 {
      page-break-after: avoid !important;
    }
    h1 + *, h2 + *, h3 + *, h4 + *, h5 + *, h6 + * {
      page-break-before: avoid !important;
    }
  `);

    const styleTag = document.createElement('style');
    styleTag.textContent = css.join('\n');
    document.head.appendChild(styleTag);

    // 4) Gap detection & reduction (only top-level containers)
    ['.resume-container', '.cover-letter'].forEach(containerSel => {
        const container = document.querySelector(containerSel);
        if (!container) return;

        const kids = Array.from(container.children)
            .filter(el => {
                const st = window.getComputedStyle(el);
                return st.display !== 'none'
                    && st.visibility !== 'hidden'
                    && el.offsetParent;
            })
            .sort((a, b) => a.getBoundingClientRect().top - b.getBoundingClientRect().top);

        for (let i = 0; i < kids.length - 1; i++) {
            const curr = kids[i], next = kids[i + 1];
            const r1 = curr.getBoundingClientRect(), r2 = next.getBoundingClientRect();
            const gap = r2.top - r1.bottom;
            if (gap > THRESHOLDS.gap) {
                const st1 = window.getComputedStyle(curr), st2 = window.getComputedStyle(next);
                const mb1 = parseFloat(st1.marginBottom) || 0;
                const mt2 = parseFloat(st2.marginTop) || 0;
                const ratio = 0.75;
                if (mb1 > 0) curr.style.marginBottom = Math.max(0, mb1 * ratio) + 'px';
                if (mt2 > 0) next.style.marginTop = Math.max(0, mt2 * ratio) + 'px';
            }
        }
    });

    // 5) Center‐compatibility for your rescale() code
    // ------------------------------------------------
    // Recompute page dims in px (@96dpi)
    const dpi = 96;
    const letterWpx = 8.5 * dpi;
    const letterHpx = 11 * dpi;
    const marginPx = 0.25 * dpi;      // 0.25" margins
    const availW = letterWpx - marginPx * 2;
    const availH = letterHpx - marginPx * 2;

    // Measure content dims
    const body = document.body, html = document.documentElement;
    const contentW = Math.max(
        body.scrollWidth, body.offsetWidth,
        html.clientWidth, html.scrollWidth,
        html.offsetWidth
    );
    const contentH = Math.max(
        body.scrollHeight, body.offsetHeight,
        html.clientHeight, html.scrollHeight,
        html.offsetHeight
    );

    // Extract existing scale (if your rescale.js ran first),
    // otherwise compute it here.
    let s = (() => {
        const t = html.style.transform || '';
        const m = t.match(/scale\(([0-9.]+)\)/);
        if (m) return parseFloat(m[1]);
        return Math.min(availW / contentW, availH / contentH);
    })();

    // Clamp to [0.75, 1.2]
    s = Math.max(0.75, Math.min(1.2, s));

    // Compute leftover space
    const scaledW = contentW * s;
    const scaledH = contentH * s;
    const offsetX = (availW - scaledW) / 2;
    const offsetY = (availH - scaledH) / 2;

    // Apply one combined translate+scale
    html.style.transform =
        `translate(${(offsetX / s).toFixed(2)}px, ${(offsetY / s).toFixed(2)}px)`
        + ` scale(${s.toFixed(2)})`;
    html.style.transformOrigin = 'top left';

    // Return scale for debugging (optional)
    return s;
}
