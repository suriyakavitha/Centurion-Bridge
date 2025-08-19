// pagination.js
export function attachPaginationControls(currentPageRef, rowsPerPageRef, dataArrayRef, renderCallback, prevBtnSelector, nextBtnSelector) {

    if (prevBtnSelector) {
        document.querySelector(prevBtnSelector)
            .addEventListener('click', () => {
                if (currentPageRef.value > 1) {
                    currentPageRef.value--;
                    renderCallback();
                }
            });
    }

    if (nextBtnSelector) {
        document.querySelector(nextBtnSelector)
            .addEventListener('click', () => {
                const totalPages = Math.ceil(dataArrayRef.value.length / rowsPerPageRef.value);
                if (currentPageRef.value < totalPages) {
                    currentPageRef.value++;
                    renderCallback();
                }
            });
    }
}
