using DVAInvest.Domain.Entities;

namespace DVAInvest.Domain.Interfaces.Application;

public interface IBrapiApplication
{
    Task<RespostaBrapi> ObterCotacaoAcaoAsync(string acao);

}