using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;

namespace Tourest.ViewComponents
{
    [ViewComponent(Name = "Footer")]
    public class FooterComponent : ViewComponent
    {
        public FooterComponent()
        {
            oClsInformation = new ClsInformation();
        }
        private readonly ClsInformation oClsInformation;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Index" ,oClsInformation.GetInformation());
        }
    }
}
