using Api_Quala.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Api_Quala.Contexts
{
    public class ConexionDB:DbContext
    {

        public ConexionDB(DbContextOptions<ConexionDB> options):base (options) 
        {
            //
        }

        public DbSet<SucursalModel> sucursalModels { get; set; }

        public DbSet<MonedaModel> monedaModels { get; set; }

    }
}
