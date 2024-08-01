using DVAInvest.Application;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Services;
using DVAInvest.Infra.Repository.Context;
using FluentAssertions;
using Moq;

namespace DVAInvest.Tests.Application
{
    public class AtivoApplicationTest
    {
        private readonly Mock<IUnitOfWork<DVAInvestContext>> _unitOfWorkMock;
        private readonly Mock<IAtivoService<DVAInvestContext>> _ativoServiceMock;
        private readonly AtivoApplication<DVAInvestContext> _ativoApplication;

        public AtivoApplicationTest()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork<DVAInvestContext>>();
            _ativoServiceMock = new Mock<IAtivoService<DVAInvestContext>>();
            _ativoApplication = new AtivoApplication<DVAInvestContext>(_unitOfWorkMock.Object, _ativoServiceMock.Object);
        }

        [Fact(DisplayName = "SaveAsync salvar ativo do usuário e realizar commit")]
        public async Task SaveAsync_DeveSalvarAtivoERealizarCommit()
        {
            // Arrange
            var ativo = new Ativo(1, enumTipoAtivo.Acao, "Petróleo Brasileiro S.A. - Petrobras", "PETR4") { Id = 1 };
            _ativoServiceMock.Setup(s => s.SaveAsync(ativo)).ReturnsAsync(ativo);

            // Act
            var result = await _ativoApplication.SaveAsync(ativo);

            // Assert
            _ativoServiceMock.Verify(s => s.SaveAsync(ativo), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(ativo);
        }

        [Fact(DisplayName = "UpdateAsync deve atualizar ativo do usuário e realizar commit")]
        public async Task UpdateAsync_DeveAtualizarUsuarioERealizarCommit()
        {
            // Arrange
            var ativo = new Ativo(1, enumTipoAtivo.Acao, "Petróleo Brasileiro S.A. - Petrobras", "PETR4") { Id = 1 };
            _ativoServiceMock.Setup(s => s.UpdateAsync(ativo)).ReturnsAsync(ativo);

            // Act
            var result = await _ativoApplication.UpdateAsync(ativo);

            // Assert
            _ativoServiceMock.Verify(s => s.UpdateAsync(ativo), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(ativo);
        }
    }
}
