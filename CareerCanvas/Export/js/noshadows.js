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
}