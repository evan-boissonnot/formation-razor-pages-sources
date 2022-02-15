using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        #region Fields
        private readonly ILogger<IndexModel> _logger;
        #endregion

        #region Constructors
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Public methods

        //public void OnGet()
        //{          

        //}

        public IActionResult OnGet()
        {
            IActionResult result = this.Page();

            this.SetListOfDrones();
            this.SetListStatus();

            return result;
        }

        //public async Task<IActionResult> OnGetAsync()
        //{
        //    this.SetListOfDrones();
        //    this.SetListStatus();

        //    return this.Page();
        //}
        #endregion

        #region Internal methods
        private void SetListOfDrones()
        {
            this.Drones.Add(new() { Matricule = "54XXD0", CreationDate = DateTime.Now, HealthStatus = HealthStatus.Broken });
            this.Drones.Add(new() { Matricule = "15FDR14", CreationDate = DateTime.Now.AddDays(-150) });
        }

        private void SetListStatus()
        {
            this.StatusList.Add(HealthStatus.OK);
            this.StatusList.Add(HealthStatus.Repair);
            this.StatusList.Add(HealthStatus.Broken);
        }
        #endregion

        #region Properties
        public List<Drone> Drones { get; set; } = new();

        public List<HealthStatus> StatusList { get; set; } = new();
        #endregion
    }
}