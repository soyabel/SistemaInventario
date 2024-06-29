using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Número de serie requerido")]
        [MaxLength(60,ErrorMessage ="El número de serie debe de tener como maximo 60 caracteres")]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage ="La descripción es requerido")]
        [MaxLength(60,ErrorMessage ="La descripcion debe tener como maximo 60 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="El precio es requerido")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "El costo es requerido")]
        public double Costo { get; set; }
        public string ImagenUrl { get; set; }
        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }
        [Required(ErrorMessage = "La categoria es requerido")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria  Categoria { get; set; }
        [Required(ErrorMessage = "La marca es requerido")]
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }
        //recursividad un producto puede estar relacionado a un mismo producto y eso es el padre
        public int? PadreId { get; set; }
        public virtual Producto Padre{ get; set; }
    }
}
