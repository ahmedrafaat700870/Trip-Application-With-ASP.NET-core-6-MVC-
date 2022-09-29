const Blog = document.getElementById("Blog");
Blog.onclick = () => {
  if (window.location.href.split("/").length > 4) {
    console.log("Larg than 4");
    window.location.href = "Blog";
  } else {
    console.log("Equal than 4");
    window.location.href = "https://localhost:7051/#Blog";
  }
};
