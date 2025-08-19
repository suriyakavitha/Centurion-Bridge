// wwwroot/js/liveDateTime.js

export function startLiveDateTime(elementId = 'liveDateTime') {
    function updateLiveDateTime() {
        const now = new Date();

        const day = now.getDate().toString().padStart(2, '0');
        const monthNames = [
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];
        const month = monthNames[now.getMonth()];
        const year = now.getFullYear();

        const hours = now.getHours().toString().padStart(2, '0');
        const minutes = now.getMinutes().toString().padStart(2, '0');
        const seconds = now.getSeconds().toString().padStart(2, '0');

        const formatted = `${day} ${month} ${year} ${hours}:${minutes}:${seconds}`;
        const el = document.getElementById(elementId);
        if (el) el.innerText = formatted;
    }

    updateLiveDateTime();
    setInterval(updateLiveDateTime, 1000);
}