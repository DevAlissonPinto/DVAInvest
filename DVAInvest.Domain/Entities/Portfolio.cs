using DVAInvest.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVAInvest.Domain.Entities;

public class Portfolio : EntityBase
{
    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public ICollection<PortfolioAtivo>? portfolioAtivos { get; set; }

    protected Portfolio() { }
    public Portfolio(int usuarioId, Usuario? usuario, string nome, string descricao)
    {
        UsuarioId = usuarioId;
        Usuario = usuario;
        Nome = nome;
        Descricao = descricao;
    }

}
