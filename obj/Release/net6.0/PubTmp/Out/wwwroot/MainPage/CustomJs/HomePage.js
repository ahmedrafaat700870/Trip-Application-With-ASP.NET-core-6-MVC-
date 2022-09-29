const searchButton = document.getElementById("search-button");
const Category = document.getElementById("Category");
const Location = document.getElementById("Location");
searchButton.onclick = () => {
  console.log(Category.value);
  console.log(Location.value);
  window.location.href = `/Shop/Sort/?CategoryId=${Category.value}&LocationId=${Location.value}`;
};
