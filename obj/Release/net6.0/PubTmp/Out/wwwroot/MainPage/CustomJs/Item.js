
window.addEventListener('load', (event) => {
  
    const Description = document.getElementById("Description");
    console.log(Description);
    Description.innerHTML = Description.getAttribute("data-description");

});