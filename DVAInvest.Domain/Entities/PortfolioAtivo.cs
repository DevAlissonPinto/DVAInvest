using DVAInvest.Domain.Entities.Base;

namespace DVAInvest.Domain.Entities;

public class PortfolioAtivo : EntityBase
{
    public int PortfolioId { get; set; }
    public Portfolio? Portfolio { get; set; }
    public int AtivoId { get; set; }
    public Ativo? Ativo { get; set; }
    public decimal Quantidade { get; set; }

    protected PortfolioAtivo() { }
    public PortfolioAtivo(int portfolioId, Portfolio? portfolio, int ativoId, Ativo? ativo, decimal quantidade)
    {
        PortfolioId = portfolioId;
        Portfolio = portfolio;
        AtivoId = ativoId;
        Ativo = ativo;
        Quantidade = quantidade;
    }

}
