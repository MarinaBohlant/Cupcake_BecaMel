using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
    [Table("Cupcake")]
    public class Cupcake
    {
        [Key]
        public int cupcake_id { get; set; }
        [Required(ErrorMessage = "A descrição curta deve ser informada")]
        [Display(Name = "Descrição Curta")]
        [MinLength(20)]
        [MaxLength(200)]
        public string desc_curta { get; set; }
        public string desc_detalhe { get; set; }
        public bool em_estoque { get; set; }
        [Required(ErrorMessage="O nome do cupcake deve ser informado")]
        [Display(Name="Nome do Cupcake")]
        [StringLength(80, MinimumLength = 10, ErrorMessage="Tamanho inválido")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O preço deve ser informado")]
        [Display(Name = "Preço")]
        [Column(TypeName="decimal(10, 2)")]
        [Range(1, 999.99)]
        public decimal preco { get; set; }
        public string img_url { get; set; }
        public string cupcake_preferido { get; set; }
        public string img_miniatura { get; set; }
        public int categoria_id { get; set; }
        [NotMapped]
        public virtual Categoria categoria { get; set; }
    }
}
