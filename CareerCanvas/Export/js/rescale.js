// file: js/rescale.js
async () => {
    // 1) wait for images & fonts
    await Promise.all(
        Array.from(document.images)
            .map(img => img.complete
                ? Promise.resolve()
                : new Promise(r => { img.onload = img.onerror = r })
            )
    );
    if (document.fonts) await document.fonts.ready;

    // 2) measure content
    const body = document.body;
    const html = document.documentElement;
    const contentH = Math.max(
        body.scrollHeight, body.offsetHeight,
        html.clientHeight, html.scrollHeight, html.offsetHeight
    );
    const contentW = Math.max(
        body.scrollWidth, body.offsetWidth,
        html.clientWidth, html.scrollWidth, html.offsetWidth
    );

    // 3) PDF “letter” in CSS px @ 96dpi
    const dpi = 96;
    const pageH = 11 * dpi;    // 1056px
    const pageW = 8.5 * dpi;   //  816px
    const margin = 0.25 * dpi;  //   24px each side
    const availH = pageH - margin * 2;
    const availW = pageW - margin * 2;

    // 4) compute scale to fit both dims
    let scale = Math.min(availH / contentH, availW / contentW);

    // 5) optional floor (you can remove or lower this if you need to cram more)
    scale = Math.max(0.5, Math.min(1.0, scale));

    // 6) return for Puppeteer
    return parseFloat(scale.toFixed(2));
}
