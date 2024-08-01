using DVAInvest.Application;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Services;
using DVAInvest.Infra.Repository.Context;
using FluentAssertions;
using Moq;

namespace DVAInvest.Tests.Application
{
    public class PortfolioApplicationTests
    {
        private readonly Mock<IUnitOfWork<DVAInvestContext>> _unitOfWorkMock;
        private readonly Mock<IPortfolioService<DVAInvestContext>> _portfolioServiceMock;
        private readonly PortfolioApplication<DVAInvestContext> _portfolioApplication;

        public PortfolioApplicationTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork<DVAInvestContext>>();
            _portfolioServiceMock = new Mock<IPortfolioService<DVAInvestContext>>();
            _portfolioApplication = new PortfolioApplication<DVAInvestContext>(_unitOfWorkMock.Object, _portfolioServiceMock.Object);
        }

        [Fact(DisplayName = "SaveAsync deve salvar o portifolio do usuário e realizar commit")]
        public async Task SaveAsync_DeveSalvarUsuarioERealizarCommit()
        {
            // Arrange
            var portifolio = new Portfolio(1, new Usuario("Vinicius", "", ""), "Portifoli 1", "Carteiras de dividendos");

            _portfolioServiceMock.Setup(s => s.SaveAsync(portifolio)).ReturnsAsync(portifolio);

            // Act
            var result = await _portfolioApplication.SaveAsync(portifolio);

            // Assert
            _portfolioServiceMock.Verify(s => s.SaveAsync(portifolio), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(portifolio);
        }

        [Fact(DisplayName = "UpdateAsync deve atualizar o portifolio do usuário e realizar commit")]
        public async Task UpdateAsync_DeveAtualizarUsuarioERealizarCommit()
        {
            // Arrange
            var portifolio = new Portfolio(1, new Usuario("Vinicius", "", ""), "Portifoli 1", "Carteiras de dividendos");

            _portfolioServiceMock.Setup(s => s.UpdateAsync(portifolio)).ReturnsAsync(portifolio);

            // Act
            var result = await _portfolioApplication.UpdateAsync(portifolio);

            // Assert
            _portfolioServiceMock.Verify(s => s.UpdateAsync(portifolio), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(portifolio);
        }
    }
}
