using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class IncidentsModel : PageModel
    {
        public JsonResult OnGet()
        {
            // Todo: utiliser un repository d�di�
            return new JsonResult(new List<Incident>() { new() { Date = DateTime.Now, Drone = new() { Matricule = "111" }, Reason = "Carsh corbeau" } });
        }
    }
}
