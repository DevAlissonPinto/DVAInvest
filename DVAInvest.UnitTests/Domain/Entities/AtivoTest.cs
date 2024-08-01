using DVAInvest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVAInvest.Tests.Domain.Entities;

/// <summary>
/// Classe responsável por testar as regras de negocio do escopo de ativos.
/// </summary>
public class AtivoTest
{

    /// <summary>
    /// Método responsável por realizar o teste Ativo_Deve_Ter_O_Codigo_Preenchido.
    /// </summary>
    [Fact]
    public void Ativo_Deve_Ter_O_Codigo_Preenchido()
    {
        
        var ativo = new Ativo(1, enumTipoAtivo.Acao, "Petróleo Brasileiro S.A. - Petrobras", "PETR4");

        Assert.True(!string.IsNullOrEmpty(ativo.Codigo));
    }

    /// <summary>
    /// Método responsável por realizar o teste Ativo_Deve_Conter_O_Nome_Preenchido.
    /// </summary>
    [Fact]
    public void Ativo_Deve_Conter_O_Nome_Preenchido()
    {
        string msg = "O Nome do ativo é de preenchimento obrigatório";

        try
        {
            var ativo = new Ativo(1, enumTipoAtivo.Acao, "Petróleo Brasileiro S.A. - Petrobras", "PETR4");

            Assert.True(!string.IsNullOrEmpty(ativo.Nome));

        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

}
