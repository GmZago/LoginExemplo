using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPederneiras.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("SaidaProdutoId")]
        [Display(Name = "Cód. Saida do Produto")]
        public int SaidaProdutoId { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("QuantidadeSaidaProduto")]
        [Display(Name = "Quantidade")]
        public int QuantidadeSaidaProduto { get; set; }

        [Column("DataSaidaProduto")]
        [Display(Name = "Data da Saida")]
        public DateTime DataSaidaProduto { get; set; }
    }
}
