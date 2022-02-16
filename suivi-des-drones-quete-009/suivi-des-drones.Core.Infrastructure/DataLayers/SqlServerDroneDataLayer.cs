using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerDroneDataLayer : IDroneDataLayer
    {
        #region Fields
        private readonly DronesDbContext? context = null;
        #endregion

        #region Constructors
        public SqlServerDroneDataLayer(DronesDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region Public methods
        public List<Drone> GetList()
        {
            var query = from item in this.context?.Drones
                        //where item.CreationDate > DateTime.Now
                        select item;

            return query.ToList();
        }
        #endregion
    }
}
