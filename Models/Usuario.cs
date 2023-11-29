using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPederneiras.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código do Usuário")]
        public int UsuarioId { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
