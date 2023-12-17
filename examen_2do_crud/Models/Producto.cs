using examen_2do_crud.Dtos;
using System.ComponentModel.DataAnnotations;

namespace examen_2do_crud.Models
{
    public class Producto
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public ProductoEnum Nombre_Productos { get; set; }
        [Required]

        public ProductoEnum Tamaño { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public SaboresEnum Sabor { get; set;}
    }
}
