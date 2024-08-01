using DVAInvest.Domain.Entities.Base;

namespace DVAInvest.Domain.Entities;

public class Usuario : EntityBase
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    // Navegação
    public ICollection<Portfolio>? Portfolios { get; set; }
    public Usuario(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;

    }
}
