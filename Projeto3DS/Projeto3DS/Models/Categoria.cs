using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int categoria_id { get; set; }
        [Required(ErrorMessage = "O nome da categoria deve ser informada")]
        [Display(Name = "Categoria")]
        [StringLength(100)]
        public string categoria_nome { get; set; }
        public string desc { get; set; }
        [NotMapped]
        public List <Cupcake> cupcake { get; set; }
    }
}
