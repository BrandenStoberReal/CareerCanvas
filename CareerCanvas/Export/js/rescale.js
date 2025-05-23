() => {
    // 1) Measure content dimensions
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

    // 2) PDF target size @96dpi, minus margins
    const dpi = 96;
    const letterHeight = 11 * dpi;    // 1056
    const letterWidth = 8.5 * dpi;   //  816
    const marginPx = 0.25 * dpi;  //   24
    const availHeight = letterHeight - marginPx * 2;
    const availWidth = letterWidth - marginPx * 2;

    // 3) Compute raw scale factors
    const heightScale = availHeight / contentHeight;
    const widthScale = availWidth / contentWidth;
    let optimalScale = Math.min(heightScale, widthScale);

    // 4) Clamp to your allowed range
    optimalScale = Math.min(1.2, optimalScale);
    optimalScale = Math.max(0.75, optimalScale);

    // 5) Calculate how much empty space remains
    //    after scaling, so we can center.
    const s = parseFloat(optimalScale.toFixed(2));
    const scaledW = contentWidth * s;
    const scaledH = contentHeight * s;
    const offsetX = (availWidth - scaledW) / 2;
    const offsetY = (availHeight - scaledH) / 2;

    // 6) Apply translation + scale,
    //    origin at the top‐left of the page margin.
    //    Note: transform functions run in order: translate → scale
    document.documentElement.style.transform =
        `translate(${(offsetX / s).toFixed(2)}px, ${(offsetY / s).toFixed(2)}px)
     scale(${s})`;
    document.documentElement.style.transformOrigin = 'top left';

    // 7) Return the scale for logging or debugging
    return s;
}
