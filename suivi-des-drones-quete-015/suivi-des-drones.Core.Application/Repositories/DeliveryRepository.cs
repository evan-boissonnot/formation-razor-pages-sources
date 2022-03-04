using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Application.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        #region Fields
        private readonly IDeliveryDataLayer dataLayer;
        #endregion

        #region Constructors
        public DeliveryRepository(IDeliveryDataLayer dataLayer)
        {
            this.dataLayer = dataLayer;
        }
        #endregion

        #region Public methods
        public List<Delivery> GetAll()
        {
            return this.dataLayer.GetAll();
        }
        #endregion
    }
}
