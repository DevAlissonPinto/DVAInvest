using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Domain.Services;

public class MovimentacaoEstoqueService<TContext> : BaseService<TContext, MovimentacaoEstoque>, IMovimentacaoEstoqueService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMovimentacaoEstoqueRepository<TContext> _repository;

    public MovimentacaoEstoqueService(
                IMovimentacaoEstoqueRepository<TContext> repository,
                    IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

}
