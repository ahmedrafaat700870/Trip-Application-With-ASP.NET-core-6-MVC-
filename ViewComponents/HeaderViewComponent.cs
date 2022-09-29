using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;

namespace Tourest.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        public HeaderViewComponent()
        {
            oClsInformation = new ClsInformation();
        }
        private readonly ClsInformation oClsInformation;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Index" , oClsInformation.HeaderInformation());
        }
    }
}
