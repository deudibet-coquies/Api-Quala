using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Quala.Modelos
{
    [Table("Sucursales",Schema = "TestQuala")]
    public class SucursalModel
    {
        [Key]
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public String Moneda { get; set; }

    }
}