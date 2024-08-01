namespace DVAInvest.Web.Models;

public class UsuarioViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    // Navegação
    public ICollection<PortfolioViewModel>? Portfolios { get; set; }
}
