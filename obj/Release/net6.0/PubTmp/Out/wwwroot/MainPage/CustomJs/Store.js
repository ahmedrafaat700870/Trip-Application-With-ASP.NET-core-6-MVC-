const category = document.getElementById("CategoryEl");
const LocationEl = document.getElementById("LocationEl");

LocationEl.onchange = (e) => {
    window.location.href = "/Shop/Sort/?LocationId=" + e.target.value;
};
category.onchange = (e) => {
    window.location.href = "/Shop/Sort/?CategoryId=" + e.target.value;
};
