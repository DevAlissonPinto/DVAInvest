using DVAInvest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVAInvest.Tests.Domain.Entities;

/// <summary>
/// Classe responsável por testar as regras de negocio do escopo de portifolio.
/// </summary>
public class PortfolioTest
{

    #region Portifolio Testes

    /// <summary>
    /// Método responsável por realizar o teste Portifolio_Deve_Ter_O_Nome_Preenchido.
    /// </summary>
    [Fact]
    public void Portifolio_Deve_Ter_O_Nome_Preenchido()
    {
        var portifolio = new Portfolio(1, new Usuario("Vinicius", "", ""), "Portifoli 1", "Carteiras de dividendos");
        Assert.True(!string.IsNullOrEmpty(portifolio.Nome));
    }

    /// <summary>
    /// Método responsável por realizar o teste Portifolio_Deve_Conter_A_Descricao_Preenchida.
    /// </summary>
    [Fact]
    public void Portifolio_Deve_Conter_A_Descricao_Preenchida()
    {
        string msg = "A Descricao do Portifolio é de preenchimento obrigatório";

        try
        {
            var portifolio = new Portfolio(1, new Usuario("Vinicius", "", ""), "Portifoli 1", "Carteiras de dividendos");
            Assert.True(!string.IsNullOrEmpty(portifolio.Descricao));

        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    /// <summary>
    /// Método responsável por realizar o teste Portifolio_Deve_Conter_Um_Usuario_Vinculado.
    /// </summary>
    [Fact]
    public void Portifolio_Deve_Conter_Um_Usuario_Vinculado()
    {
        string msg = "O Portifolio deve conter um usuário vinculado.";

        try
        {
            var portifolio = new Portfolio(1, new Usuario("Vinicius", "", ""), "Portifoli 1", "Carteiras de dividendos");
            Assert.True(portifolio.UsuarioId > 0);

        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    #endregion


    #region Portifolio x Ativo Testes

    /// <summary>
    /// Método responsável por realizar o teste Vincular_O_Portifolio_Ao_Ativo_Deve_Conter_Um_Codigo_De_Ativo.
    /// </summary>
    [Fact]
    public void Vincular_O_Portifolio_Ao_Ativo_Deve_Conter_Um_Codigo_De_Ativo()
    {
        string msg = "Ao vincular no portifolio é obrigatório ter um ativo vinculado.";

        try
        {

            var portifolio = new PortfolioAtivo(1, new Portfolio(1, new Usuario("Vinicius", "vinicius@gmail.com", "234212"), "Portifoli 1", "Carteiras de dividendos"), 1, null, 10);
            Assert.True(portifolio.AtivoId > 0);

        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    /// <summary>
    /// Método responsável por realizar o teste Vincular_O_Portifolio_Ao_Ativo_Deve_Conter_Um_Quantidade_Maior_Que_Zero.
    /// </summary>
    [Fact]
    public void Vincular_O_Portifolio_Ao_Ativo_Deve_Conter_Um_Quantidade_Maior_Que_Zero()
    {
        string msg = "A Quantidade de Ativos Dentro do Portifolio é de preenchimento obrigatorio.";

        try
        {

            var portifolio = new PortfolioAtivo(1, new Portfolio(1, new Usuario("Vinicius", "vinicius@gmail.com", "234212"), "Portifoli 1", "Carteiras de dividendos"), 1, null, 10);
            Assert.True(portifolio.Quantidade > 0);

        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    #endregion



}
