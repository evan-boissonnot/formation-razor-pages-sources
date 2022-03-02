using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace suivi_des_drones.Web.UI.Pages
{
    public class CreateDroneModel : PageModel
    {
        #region Fields
        private readonly IDroneRepository repository;
        #endregion

        #region Constructors
        public CreateDroneModel(IDroneRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region Public methods
        public void OnGet()
        {
        }

        //public void OnPost(string dateCreation, string matricule)
        //public void OnPost(Drone drone) // (TestClass test)
        public IActionResult OnPost()
        {
            IActionResult result = this.Page();

            if (this.ModelState.IsValid)
            {
                //string matricule = this.Request.Form["matricule"];
                this.repository.Save(this.MonDrone);
                this.MonDrone = new Drone();
                this.ModelState.Clear();

                result = this.RedirectToPage("./CreateDrone");
            }

            return result;
        }
        #endregion

        #region Properties
        [BindProperty]
        public Drone MonDrone { get; set; }
        #endregion
    }

    public class TestClass
    {
        public string Matricule { get; set; }
    }
}
