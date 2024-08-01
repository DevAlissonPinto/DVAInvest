using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Services;

namespace DVAInvest.Domain.Interfaces.Services;

public interface IBrapiService
{
    Task<RespostaBrapi> ObterCotacaoAcaoAsync(string acao);
}