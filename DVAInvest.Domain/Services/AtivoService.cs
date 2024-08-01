using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Domain.Services;

public class AtivoService<TContext> : BaseService<TContext, Ativo>, IAtivoService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IAtivoRepository<TContext> _repository;

    public AtivoService(
                       IAtivoRepository<TContext> repository,
                                          IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

}
