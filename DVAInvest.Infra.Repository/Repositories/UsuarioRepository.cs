using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Repositories;

public class UsuarioRepository<TContext> : BaseRepository<TContext, Usuario>, IUsuarioRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Usuario> _dbSet => ((DVAInvestContext)UnitOfWork).Set<Usuario>();

    public UsuarioRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}