() => {
    // Try to get the background color from various elements
    const bodyBg = window.getComputedStyle(document.body).backgroundColor;
    if (bodyBg && bodyBg !== 'rgba(0, 0, 0, 0)' && bodyBg !== 'transparent') {
        return bodyBg;
    }

    // Check if there's a main container with background
    const mainContainers = document.querySelectorAll('main, .container, .content, #content, #main');
    for (const container of mainContainers) {
        const containerBg = window.getComputedStyle(container).backgroundColor;
        if (containerBg && containerBg !== 'rgba(0, 0, 0, 0)' && containerBg !== 'transparent') {
            return containerBg;
        }
    }

    // Default to white if no background found
    return 'rgb(255, 255, 255)';
}