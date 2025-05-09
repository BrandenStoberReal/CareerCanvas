() => {
    // Constants and utilities
    const ELEGANT_CARDS_IDENTIFIERS = ['elegant_cards'];
    const SPACING_VALUES = {
        standard: { margin: '10px', padding: '15px', headerMargin: '5px', headerPadding: '5px' },
        elegant: { margin: '5px', padding: '10px', headerMargin: '0', headerPadding: '0' }
    };

    // Helper function to check if element has computed style exceeding a threshold
    const hasExcessiveSpacing = (element, property, threshold) => {
        return parseFloat(window.getComputedStyle(element)[property]) > threshold;
    };

    // Helper function to check if element is in normal document flow
    const isInNormalFlow = (element) => {
        const position = window.getComputedStyle(element).position;
        return position !== 'absolute' && position !== 'fixed';
    };

    // Detect if we're using the elegant_cards template
    const isElegantCardsTemplate = ELEGANT_CARDS_IDENTIFIERS.some(identifier =>
        document.body.innerHTML.includes(identifier) ||
        !!document.querySelector(`link[href*="${identifier}"]`) ||
        document.documentElement.outerHTML.includes(identifier)
    );

    // Use the appropriate spacing values based on template
    const spacing = isElegantCardsTemplate ? SPACING_VALUES.elegant : SPACING_VALUES.standard;

    // 1. Header optimization
    const header = document.querySelector('header');
    if (header) {
        header.style.marginBottom = spacing.headerMargin;
        header.style.paddingBottom = spacing.headerPadding;
        header.style.pageBreakAfter = 'avoid';
    }

    // 2. Template-specific optimizations
    if (isElegantCardsTemplate) {
        // Elegant cards template special handling
        const mainContent = document.querySelector('.resume-body, .content-area, main');
        if (mainContent) {
            mainContent.style.marginTop = '-10px'; // Negative margin to eliminate gap
            mainContent.style.paddingTop = '0';
            mainContent.style.pageBreakBefore = 'avoid';
        }

        // Optimize card elements
        document.querySelectorAll('.card, .section-card, .content-card').forEach(card => {
            card.style.marginBottom = '8px';
            card.style.pageBreakInside = 'avoid';
        });
    } else {
        // Standard template handling - optimize first section spacing
        const firstSectionSelectors = [
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

        // Find and adjust the first main content section
        for (const selector of firstSectionSelectors) {
            const element = document.querySelector(selector);
            if (element) {
                element.style.marginTop = '5px';
                element.style.paddingTop = '5px';
                break; // Stop after finding and adjusting the first matching element
            }
        }
    }

    // 3. Global spacing optimization for all container elements
    document.querySelectorAll('section, article, div, main').forEach(element => {
        if (!isInNormalFlow(element)) return;

        // Reduce excessive margins and paddings
        if (hasExcessiveSpacing(element, 'marginTop', 15)) {
            element.style.marginTop = spacing.margin;
        }
        if (hasExcessiveSpacing(element, 'marginBottom', 15)) {
            element.style.marginBottom = spacing.margin;
        }
        if (hasExcessiveSpacing(element, 'paddingTop', 20)) {
            element.style.paddingTop = spacing.padding;
        }
        if (hasExcessiveSpacing(element, 'paddingBottom', 20)) {
            element.style.paddingBottom = spacing.padding;
        }
    });

    // 4. Gap detection and fixing between elements
    // Get all visible elements in the document
    const allVisibleElements = Array.from(document.body.querySelectorAll('*')).filter(el => {
        const style = window.getComputedStyle(el);
        return style.display !== 'none' &&
            style.visibility !== 'hidden' &&
            style.opacity !== '0' &&
            el.offsetParent !== null;
    });

    // Sort by vertical position
    allVisibleElements.sort((a, b) =>
        a.getBoundingClientRect().top - b.getBoundingClientRect().top
    );

    // Find and fix gaps between consecutive elements
    for (let i = 0; i < allVisibleElements.length - 1; i++) {
        const current = allVisibleElements[i];
        const next = allVisibleElements[i + 1];

        // Skip if either element is not in normal flow
        if (!isInNormalFlow(current) || !isInNormalFlow(next)) continue;

        // Skip parent-child relationships
        if (current.contains(next) || next.contains(current)) continue;

        const currentRect = current.getBoundingClientRect();
        const nextRect = next.getBoundingClientRect();

        // Check for excessive gap
        if (nextRect.top > currentRect.bottom) {
            const gap = nextRect.top - currentRect.bottom;

            // Only fix gaps larger than 20px
            if (gap > 20) {
                const currentMarginBottom = parseFloat(window.getComputedStyle(current).marginBottom);
                const nextMarginTop = parseFloat(window.getComputedStyle(next).marginTop);

                // Apply proportional adjustments
                const reductionRatio = 0.75; // Reduce by 75% to avoid complete elimination
                if (currentMarginBottom > 0) {
                    current.style.marginBottom = Math.max(0, currentMarginBottom * reductionRatio) + 'px';
                }
                if (nextMarginTop > 0) {
                    next.style.marginTop = Math.max(0, nextMarginTop * reductionRatio) + 'px';
                }
            }
        }
    }

    // 5. Image handling
    document.querySelectorAll('img').forEach(img => {
        img.style.maxWidth = '100%';
        img.style.height = 'auto';
    });

    // 6. Page break controls
    // Prevent section breaks
    document.querySelectorAll('section, article, .card, .section-card, .content-card').forEach(element => {
        if (element.textContent.trim().length > 0 || element.querySelector('img')) {
            element.style.pageBreakInside = 'avoid';
        }
    });

    // Keep headings with their content
    document.querySelectorAll('h1, h2, h3, h4, h5, h6').forEach(heading => {
        heading.style.pageBreakAfter = 'avoid';

        const nextElement = heading.nextElementSibling;
        if (nextElement) {
            nextElement.style.pageBreakBefore = 'avoid';
        }
    });
}
