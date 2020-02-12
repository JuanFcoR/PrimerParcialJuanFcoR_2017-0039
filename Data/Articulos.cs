using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialJuanFcoR_2017_0039.Data
{
    public class Articulos
    {
        [Key]
        public int ArtticuloId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Precio { get; set; }

        public Articulos()
        {
            ArtticuloId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }
    }
}
