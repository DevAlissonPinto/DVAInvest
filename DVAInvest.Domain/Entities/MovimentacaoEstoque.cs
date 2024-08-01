using DVAInvest.Domain.Entities.Base;
using DVAInvest.Domain.Enum;
using System.Windows.Markup;

namespace DVAInvest.Domain.Entities
{
    public class MovimentacaoEstoque : EntityBase
    {
        public int Quantidade { get; set; }
        public decimal? Preco { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public TipoMovimentacaoEnum TipoMovimentacao { get; set; }

        public int EstoqueId { get; set; }
        public Estoque Estoque { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }

        protected MovimentacaoEstoque()
        {
            
        }

        public MovimentacaoEstoque(int quantidade, decimal? preco, DateTime dataMovimentacao, TipoMovimentacaoEnum tipoMovimentacao, int estoqueId, int materialId)
        {
            Quantidade = quantidade;
            Preco = preco;
            DataMovimentacao = dataMovimentacao;
            TipoMovimentacao = tipoMovimentacao;
            EstoqueId = estoqueId;
            MaterialId = materialId;

            ValidarQuantidadeMenorIgualZero();
            ValidarPrecoMenorIgualZero();
        }

        private void ValidarQuantidadeMenorIgualZero()
        {
            if (Quantidade <= 0)
                throw new Exception("A quantidade não pode ser zero ou negativo!");
        }

        private void ValidarPrecoMenorIgualZero()
        {
            if (Preco.HasValue && Preco <= 0)
                throw new Exception("O preço não pode ser zero ou negativo!");
        }
    }
}
