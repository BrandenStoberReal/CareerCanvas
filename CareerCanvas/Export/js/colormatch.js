() => {
    // Helper function to check if a color is valid (not transparent)
    const isValidColor = (color) => {
        return color &&
            color !== 'rgba(0, 0, 0, 0)' &&
            color !== 'transparent' &&
            !color.includes('rgba(0, 0, 0, 0)');
    };

    // First, try to get the body background color as this is likely 
    // the "blueish box" surrounding the document
    const bodyStyle = window.getComputedStyle(document.body);
    const bodyBgColor = bodyStyle.backgroundColor;

    if (isValidColor(bodyBgColor) && bodyBgColor !== 'rgb(255, 255, 255)') {
        // If body has a non-white background, it's likely our target color
        return bodyBgColor;
    }

    // Check HTML element background (sometimes this contains the page background)
    const htmlBgColor = window.getComputedStyle(document.documentElement).backgroundColor;
    if (isValidColor(htmlBgColor) && htmlBgColor !== 'rgb(255, 255, 255)') {
        return htmlBgColor;
    }

    // Template-specific checks
    // For resume template
    if (document.querySelector('.section')) {
        // In the resume template, the body background is #f8f9fa
        return 'rgb(248, 249, 250)'; // #f8f9fa in RGB
    }

    // For cover letter template
    if (document.querySelector('.cover-letter')) {
        // In the cover letter template, the body background is #f9f9f9
        return 'rgb(249, 249, 249)'; // #f9f9f9 in RGB
    }

    // If still not found, check specific container elements that might define page background
    const containerSelectors = [
        // General container selectors
        '.container',
        '#container',
        'main',
        // Resume specific selectors
        '.section:first-child',
        // Cover letter specific selectors
        '.cover-letter'
    ];

    for (const selector of containerSelectors) {
        const elements = document.querySelectorAll(selector);
        for (const element of elements) {
            // Check if element is positioned relative to viewport (likely full page)
            const position = window.getComputedStyle(element).position;
            const rect = element.getBoundingClientRect();

            // If it's a large element (likely page container)
            if (rect.width > document.documentElement.clientWidth * 0.9 &&
                rect.height > document.documentElement.clientHeight * 0.9) {
                const bgColor = window.getComputedStyle(element).backgroundColor;
                if (isValidColor(bgColor)) {
                    return bgColor;
                }
            }
        }
    }

    // Get computed background-color of all elements with significant size
    const allElements = Array.from(document.querySelectorAll('*')).filter(el => {
        const rect = el.getBoundingClientRect();
        // Consider only elements that take up significant space
        return rect.width > document.documentElement.clientWidth * 0.8 &&
            rect.height > document.documentElement.clientHeight * 0.8;
    });

    // Sort larger elements first (more likely to be the page background)
    allElements.sort((a, b) => {
        const rectA = a.getBoundingClientRect();
        const rectB = b.getBoundingClientRect();
        return (rectB.width * rectB.height) - (rectA.width * rectA.height);
    });

    // Check these large elements for background color
    for (const el of allElements) {
        const bgColor = window.getComputedStyle(el).backgroundColor;
        if (isValidColor(bgColor)) {
            return bgColor;
        }
    }

    // Default to light gray if nothing else works (better than white as a fallback)
    return 'rgb(248, 249, 250)';
}
