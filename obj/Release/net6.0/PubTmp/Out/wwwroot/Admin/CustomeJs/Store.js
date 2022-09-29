const CategoryEl = document.getElementById("CategoryEl");
const LocationEl = document.getElementById("LocationEl");

LocationEl.onchange = (e) => {
  window.location.href =
    "/adminToAdminToPanel/Tour/Sort/?LocationId=" + e.target.value;
};
CategoryEl.onchange = (e) => {
  window.location.href =
    "/adminToAdminToPanel/Tour/Sort/?CategoryId=" + e.target.value;
};
