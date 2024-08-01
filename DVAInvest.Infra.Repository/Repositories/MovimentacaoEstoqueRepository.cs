using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Repositories;

public class MovimentacaoEstoqueRepository<TContext> : BaseRepository<TContext, MovimentacaoEstoque>, IMovimentacaoEstoqueRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<MovimentacaoEstoque> _dbSet => ((DVAInvestContext)UnitOfWork).Set<MovimentacaoEstoque>();

    public MovimentacaoEstoqueRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}
