using suivi_des_drones.Core.Infrastructure.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    /// <summary>
    /// Classe parent pour tous les datalayers qui vont avoir besoin du context
    /// </summary>
    public abstract class BaseSqlServerDataLayer 
    {
        #region Fields
        private readonly DronesDbContext? context = null;
        #endregion

        #region Constructors
        public BaseSqlServerDataLayer(DronesDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region Properties
        protected DronesDbContext Context { get => this.context; }
        #endregion
    }
}
