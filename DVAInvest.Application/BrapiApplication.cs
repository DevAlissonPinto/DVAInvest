using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Application;

public class BrapiApplication : IBrapiApplication
{
    private readonly IBrapiService _service;

    public BrapiApplication(IBrapiService service)
    {
        _service = service;
    }

    public Task<RespostaBrapi> ObterCotacaoAcaoAsync(string acao)
    {
        return _service.ObterCotacaoAcaoAsync(acao);
    }
}