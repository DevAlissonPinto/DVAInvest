using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVAInvest.Web.Models;

public class PortfolioViewModel
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public UsuarioViewModel? Usuario { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public ICollection<PortfolioAtivoViewModel> portfolioAtivos { get; set; }


}


public class PortfolioAtivoViewModel
{
    public int PortfolioId { get; set; }
    public PortfolioViewModel? Portfolio { get; set; }
    public int AtivoId { get; set; }
    public AtivoViewModel? Ativo { get; set; }

    public decimal Quantidade { get; set; }
}
