() => {
    // Get the content dimensions using more comprehensive measurements
    const body = document.body;
    const html = document.documentElement;
    const contentHeight = Math.max(
        body.scrollHeight,
        body.offsetHeight,
        html.clientHeight,
        html.scrollHeight,
        html.offsetHeight
    );
    const contentWidth = Math.max(
        body.scrollWidth,
        body.offsetWidth,
        html.clientWidth,
        html.scrollWidth,
        html.offsetWidth
    );

    // Letter size dimensions in pixels at 96 DPI
    const letterHeight = 1056; // 11 inches
    const letterWidth = 816;   // 8.5 inches

    // Account for margins (0.25 inch on each side)
    const marginPixels = 24;   // 0.25 inches * 96 DPI
    const availableHeight = letterHeight - (marginPixels * 2);
    const availableWidth = letterWidth - (marginPixels * 2);

    // Calculate scaling factors
    const heightScale = availableHeight / contentHeight;
    const widthScale = availableWidth / contentWidth;

    // Use the smaller scale to ensure content fits in both dimensions
    let optimalScale = Math.min(heightScale, widthScale);

    // Apply more flexible scaling limits to better fit content
    optimalScale = Math.min(1.2, optimalScale);  // Allow up to 120% scaling for better readability
    optimalScale = Math.max(0.75, optimalScale); // Don't scale down below 75%

    // Round to 2 decimal places for consistent rendering
    return parseFloat(optimalScale.toFixed(2));
}