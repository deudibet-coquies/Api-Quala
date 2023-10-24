using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Quala.Modelos
{
    [Table("Monedas", Schema = "TestQuala")]

    public class MonedaModel
    {
        [Key]
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
