using System.ComponentModel.DataAnnotations;

namespace Imc.Entities;

public class Account
{
    public Account(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Username é um campo obrigatório.")]
    [MinLength(3, ErrorMessage = "Username precisa de no mínimo 3 caracteres.")]
    [MaxLength(40, ErrorMessage = "Username precisa de no máximo 40 caracteres.")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage ="Email é um campo obrigatório.")]
    [MinLength(8, ErrorMessage = "Email precisa de no mínimo 8 caracteres.")]
    [MaxLength(120, ErrorMessage = "Email precisa de no máximo 120 caracteres")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Senha é um campo obrigatório.")]
    [MinLength(12, ErrorMessage = "Senha precisa de no mínimo 12 caracteres.")]
    [MaxLength(120, ErrorMessage = "Senha precisa de no máximo 120 caracteres.")]
    public string Password { get; set; } = string.Empty;
}
