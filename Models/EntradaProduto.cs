using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPederneiras.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("EntradaProdutoId")]
        [Display(Name = "Cód. Entrada Produto")]
        public int EntradaProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }

        public Fornecedor? Fornecedor { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade")]
        public int QuantidadeEntrada { get; set; }

        [Column("DataEntrada")]
        [Display(Name ="Data Entrada")]
        public DateTime DataEntrada { get; set; }
    }
}
