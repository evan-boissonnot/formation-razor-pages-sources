using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.Databases
{
    internal class AuthenticationContextFactory : IDesignTimeDbContextFactory<AuthenticationContext>
    {
        #region Public methods
        public AuthenticationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AuthenticationContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-1446PBQ;Database=SuiviDesDrones;Trusted_Connection=True;");

            return new AuthenticationContext(optionsBuilder.Options);
        }
        #endregion
    }
}
