using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPederneiras.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Cód. Produto")]
        public int ProdutoId { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do Produto")]
        public string ProdutoNome { get; set;} = string.Empty;

        [Column("ProdutoEstoque")]
        [Display(Name = "Quantidade em Estoque")]
        public int ProdutoEstoque { get; set; }
    }
}
