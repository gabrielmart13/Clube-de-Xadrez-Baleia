using System.ComponentModel.DataAnnotations;

namespace XadrezBaleia.Domain.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public string RegistroEscoteiro { get; set; } = string.Empty;
        public string Ramo { get; set; } = string.Empty;
        public int Rating { get; set; } = 1000;
        public string Papel { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}