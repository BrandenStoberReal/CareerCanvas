() => {
    // 1) Measure your page…
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

    // 2) PDF target dims @96dpi
    const letterHeight = 11 * 96; // 1056
    const letterWidth = 8.5 * 96; //  816
    const marginPixels = 0.25 * 96; //   24
    const availHeight = letterHeight - marginPixels * 2;
    const availWidth = letterWidth - marginPixels * 2;

    // 3) Compute scale
    const heightScale = availHeight / contentHeight;
    const widthScale = availWidth / contentWidth;
    let optimalScale = Math.min(heightScale, widthScale);

    // 4) Clamp
    optimalScale = Math.min(1.2, optimalScale);
    optimalScale = Math.max(0.75, optimalScale);

    // 5) Apply it
    document.documentElement.style.transform = `scale(${optimalScale.toFixed(2)})`;
    document.documentElement.style.transformOrigin = 'top left';

    // 6) (Optional) return for debugging
    return optimalScale;
}
