using DVAInvest.Domain.Enum;

namespace DVAInvest.Web.Models
{
    public class MovimentacaoSaldoViewModel
    {
        public DateTime DataMovimentacao { get; set; }
        public string EstoqueNome { get; set; }
        public string MaterialNome { get; set; }
        public TipoMovimentacaoEnum TipoMovimentacao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int SaldoCumulativo { get; set; }
    }


}
