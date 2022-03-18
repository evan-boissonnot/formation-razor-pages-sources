using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace suivi_des_drones.Web.UI.Pages
{
    public class CreateIncidentModel : PageModel
    {
        #region Fields
        private readonly IHostEnvironment environment;
        #endregion

        #region Constructors
        public CreateIncidentModel(IHostEnvironment environment)
        {
            this.environment = environment;
        }
        #endregion

        #region Public methods
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            using var file = new FileStream(this.environment.ContentRootPath + "./" + this.PictureFile.FileName, FileMode.OpenOrCreate);

            await this.PictureFile.CopyToAsync(file);

            return this.Page();
        }
        #endregion

        #region Properties
        [BindProperty]
        public IFormFile PictureFile { get; set; }
        #endregion
    }
}
