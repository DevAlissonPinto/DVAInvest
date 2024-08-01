using DVAInvest.Domain.Entities.Base;

namespace DVAInvest.Domain.Entities;

public class Ativo: EntityBase
{
    public int Id { get; set; }
    public enumTipoAtivo TipoAtivo { get; set; }
    public string Nome { get; set; }
    public string Codigo { get; set; }


    public Ativo(int id, enumTipoAtivo tipoAtivo, string nome, string codigo)
    {
        Id = id;
        TipoAtivo = tipoAtivo;
        Nome = nome;
        Codigo = codigo;

    }

}

public enum enumTipoAtivo
{
    Acao = 1,
    FII = 2,
    ETF = 3,
    Cripto = 4
}