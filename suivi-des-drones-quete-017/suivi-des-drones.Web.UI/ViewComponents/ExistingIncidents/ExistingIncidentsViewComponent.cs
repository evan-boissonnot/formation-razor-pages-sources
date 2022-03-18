using Microsoft.AspNetCore.Mvc;

namespace suivi_des_drones.Web.UI.ViewComponents
{
    public class ExistingIncidentsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
