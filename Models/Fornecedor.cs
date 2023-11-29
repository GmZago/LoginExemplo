using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPederneiras.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("FornecedorId")]
        [Display(Name = "Cód. Fornecedor")]
        public int FornecedorId { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do Fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;
    }
}
