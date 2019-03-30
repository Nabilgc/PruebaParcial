using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIparcial.Models
{
    public enum TipoEstado

    {
        Ativo,
        Inactivo
    }
    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }

    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Product Name")]

        public string Nombre { get; set; }
        [Required]

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }
        [Required]

        public TipoUnidad Unidad { get; set; }

        [Required]

        public TipoEstado Estado { get; set; }




    }
}