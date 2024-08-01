namespace DVAInvest.Web.Models;

public class PesaquisaMovimentoViewModel
{
    public int TipoMovimento { get; set; }
    public string NumeroMovimento { get; set; }
    public int AlmoxarifadoId { get; set; }
    public DateTime DataInicial { get; set; }
    public DateTime DataFinal { get; set; }
}
