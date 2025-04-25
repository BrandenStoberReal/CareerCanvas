() => {
    // Get header element once
    const header = document.querySelector('header');

    // Remove all shadow effects throughout the document
    document.querySelectorAll('*').forEach(element => {
        // Remove box-shadow from all elements
        element.style.boxShadow = 'none';

        // Remove text-shadow from all elements
        element.style.textShadow = 'none';

        // Remove filter shadows (drop-shadow)
        if (element.style.filter) {
            element.style.filter = element.style.filter.replace(/drop-shadow\([^)]*\)/g, '');
        }

        // Remove -webkit-box-shadow for Safari compatibility
        element.style.webkitBoxShadow = 'none';
    });

    // Ensure the header and page container have no shadows
    if (header) {
        header.style.boxShadow = 'none';
        header.style.webkitBoxShadow = 'none';
    }

    document.querySelectorAll('.page, .container, main, .content').forEach(container => {
        container.style.boxShadow = 'none';
        container.style.webkitBoxShadow = 'none';
    });

    // Remove any shadow-related classes
    document.querySelectorAll('.shadow, .box-shadow, .card-shadow').forEach(element => {
        element.classList.remove('shadow', 'box-shadow', 'card-shadow');
    });

    // Special handling for elegant_cards template
    const isElegantCardsTemplate = document.body.innerHTML.includes('elegant_cards') ||
        document.querySelector('link[href*=""elegant_cards""]') !== null ||
        document.documentElement.outerHTML.includes('elegant_cards');

    // Fix header spacing issues - using the already declared header variable
    if (header) {
        header.style.marginBottom = isElegantCardsTemplate ? '0' : '5px';
        header.style.paddingBottom = isElegantCardsTemplate ? '0' : '5px';
        header.style.pageBreakAfter = 'avoid';
    }

    // For elegant_cards template, directly select main content container
    if (isElegantCardsTemplate) {
        // Specific targeting for elegant_cards template
        const mainContent = document.querySelector('.resume-body, .content-area, main');
        if (mainContent) {
            mainContent.style.marginTop = '0';
            mainContent.style.paddingTop = '0';
            // Use negative margin to eliminate any gap
            mainContent.style.marginTop = '-10px';
            mainContent.style.pageBreakBefore = 'avoid';
        }

        // Target card elements in elegant_cards template
        document.querySelectorAll('.card, .section-card, .content-card').forEach(card => {
            card.style.marginBottom = '8px';
            card.style.pageBreakInside = 'avoid';
        });
    } else {
        // Standard handling for other templates
        const firstSectionSelectors = [
            '.main-content:first-child',
            '.section:first-child',
            'main > section:first-child',
            'main > div:first-child',
            '.container > section:first-child',
            '.container > div:first-child',
            'body > section:first-child',
            'body > div:not(header):first-of-type'
        ];

        firstSectionSelectors.forEach(selector => {
            const element = document.querySelector(selector);
            if (element) {
                element.style.marginTop = '5px';
                element.style.paddingTop = '5px';
            }
        });
    }

    // Aggressive gap reduction for all templates
    document.querySelectorAll('section, article, div, main').forEach(element => {
        // Skip elements with position:absolute as they don't affect normal flow
        const position = window.getComputedStyle(element).position;
        if (position === 'absolute' || position === 'fixed') {
            return;
        }

        // Reduce excessive margins and paddings
        if (parseFloat(window.getComputedStyle(element).marginTop) > 15) {
            element.style.marginTop = isElegantCardsTemplate ? '5px' : '10px';
        }
        if (parseFloat(window.getComputedStyle(element).marginBottom) > 15) {
            element.style.marginBottom = isElegantCardsTemplate ? '5px' : '10px';
        }
        if (parseFloat(window.getComputedStyle(element).paddingTop) > 20) {
            element.style.paddingTop = isElegantCardsTemplate ? '10px' : '15px';
        }
        if (parseFloat(window.getComputedStyle(element).paddingBottom) > 20) {
            element.style.paddingBottom = isElegantCardsTemplate ? '10px' : '15px';
        }
    });

    // Real-time gap detection and fixing
    const allVisibleElements = Array.from(document.body.querySelectorAll('*')).filter(el => {
        const style = window.getComputedStyle(el);
        return style.display !== 'none' &&
            style.visibility !== 'hidden' &&
            style.opacity !== '0' &&
            el.offsetParent !== null;
    });

    // Sort elements by their vertical position
    allVisibleElements.sort((a, b) => {
        return a.getBoundingClientRect().top - b.getBoundingClientRect().top;
    });

    // Check for gaps between consecutive elements
    for (let i = 0; i < allVisibleElements.length - 1; i++) {
        const current = allVisibleElements[i];
        const next = allVisibleElements[i + 1];

        // Skip elements that are not in the normal flow
        if (window.getComputedStyle(current).position === 'absolute' ||
            window.getComputedStyle(next).position === 'absolute') {
            continue;
        }

        const currentRect = current.getBoundingClientRect();
        const nextRect = next.getBoundingClientRect();

        // Check if next element is actually below and not a child
        if (nextRect.top > currentRect.bottom && !current.contains(next) && !next.contains(current)) {
            const gap = nextRect.top - currentRect.bottom;

            // If gap is excessive (>20px), reduce it
            if (gap > 20) {
                // Apply margin adjustment based on computed styles
                const currentMarginBottom = parseFloat(window.getComputedStyle(current).marginBottom);
                const nextMarginTop = parseFloat(window.getComputedStyle(next).marginTop);

                if (currentMarginBottom > 0) {
                    current.style.marginBottom = Math.max(0, currentMarginBottom - (gap / 2)) + 'px';
                }
                if (nextMarginTop > 0) {
                    next.style.marginTop = Math.max(0, nextMarginTop - (gap / 2)) + 'px';
                }
            }
        }
    }

    // Make sure all images have appropriate sizing
    document.querySelectorAll('img').forEach(img => {
        img.style.maxWidth = '100%';
        img.style.height = 'auto';
    });

    // Page break controls that work with any template
    document.querySelectorAll('section, article, .card, .section-card, .content-card').forEach(element => {
        if (element.textContent.trim().length > 0 || element.querySelector('img')) {
            element.style.pageBreakInside = 'avoid';
        }
    });

    // Keep headings with their content
    document.querySelectorAll('h1, h2, h3, h4, h5, h6').forEach(heading => {
        heading.style.pageBreakAfter = 'avoid';

        // Also ensure the next element stays with its heading
        const nextElement = heading.nextElementSibling;
        if (nextElement) {
            nextElement.style.pageBreakBefore = 'avoid';
        }
    });
}