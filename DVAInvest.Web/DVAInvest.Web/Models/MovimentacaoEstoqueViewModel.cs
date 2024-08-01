using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Enum;

public class MovimentacaoEstoqueViewModel
{
    public int EstoqueId { get; set; }
    public Estoque? Estoque { get; set; }
    public int MaterialId { get; set; }
    public Material? Material { get; set; }
    public DateTime DataMovimentacao { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }
    public TipoMovimentacaoEnum TipoMovimentacao { get; set; }

    // Método para converter ViewModel em Model
    public MovimentacaoEstoque ToModel()
    {
        return new MovimentacaoEstoque(this.Quantidade, this.Preco, this.DataMovimentacao, this.TipoMovimentacao, this.EstoqueId, this.MaterialId);
    }
}

