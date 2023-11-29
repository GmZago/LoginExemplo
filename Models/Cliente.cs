using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPederneiras.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Cód. Cliente")]
        public int ClienteId { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;
    }
}
