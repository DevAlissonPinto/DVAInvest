using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Repositories;
using DVAInvest.Domain.Interfaces.Services;

namespace DVAInvest.Domain.Services;

public class MaterialService<TContext> : BaseService<TContext, Material>, IMaterialService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMaterialRepository<TContext> _repository;

    public MaterialService(
                        IMaterialRepository<TContext> repository,
                            IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

    public override async Task<Material> SaveAsync(Material entidade)
    {
        bool existeMaterialNome = await ValidarMaterialNomeExistente(entidade);
        bool existeMaterialCodigo = await ValidarMaterialCodigoExistente(entidade);

        var msg = RetornoValidacao(existeMaterialNome, existeMaterialCodigo);

        if (!string.IsNullOrEmpty(msg))
            throw new Exception(msg);

        entidade.AtualizarDataInclusao();
        entidade.Validate();
        await _repository.SaveAsync(entidade);
        return entidade;
    }

    public override async Task<Material> UpdateAsync(Material entidade)
    {
        bool existeMaterialNome = await ValidarMaterialNomeExistente(entidade);
        bool existeMaterialCodigo = await ValidarMaterialCodigoExistente(entidade);

        var msg = RetornoValidacao(existeMaterialNome, existeMaterialCodigo);

        if (!string.IsNullOrEmpty(msg))
            throw new Exception(msg);

        entidade.AtualizarDataAlteracao();
        entidade.Validate();
        await _repository.UpdateAsync(entidade);
        return entidade;
    }

    public async Task<bool> ValidarMaterialNomeExistente(Material entidade)
    {
        var materiais = await _repository.GetAllAsync(x => x.Nome.Equals(entidade.Nome));
        return materiais.Any(x => x.Id != entidade.Id);
    }

    public async Task<bool> ValidarMaterialCodigoExistente(Material entidade)
    {
        var materiais = await _repository.GetAllAsync(x => x.Codigo.Equals(entidade.Codigo));
        return materiais.Any(x => x.Id != entidade.Id);
    }

    private string RetornoValidacao(bool existeMaterialNome, bool existeMaterialCodigo)
    {
        string msg = "";
        if (existeMaterialNome)
            msg = "Já existe um material com esse nome!";

        if (existeMaterialCodigo)
            msg += " Já existe um material com esse código!";

        return msg;
    }
}
