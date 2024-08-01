using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Domain.Services;

public class UsuarioService<TContext> : BaseService<TContext, Usuario>, IUsuarioService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IUsuarioRepository<TContext> _repository;

    public UsuarioService(
                            IUsuarioRepository<TContext> repository,
                            IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

}