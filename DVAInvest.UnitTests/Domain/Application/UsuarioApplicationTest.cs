using DVAInvest.Application;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using DVAInvest.Domain.Interfaces.Services;
using DVAInvest.Infra.Repository.Context;
using FluentAssertions;
using Moq;

namespace DVAInvest.Tests.Application
{
    public class UsuarioApplicationTests
    {
        private readonly Mock<IUnitOfWork<DVAInvestContext>> _unitOfWorkMock;
        private readonly Mock<IUsuarioService<DVAInvestContext>> _usuarioServiceMock;
        private readonly UsuarioApplication<DVAInvestContext> _usuarioApplication;

        public UsuarioApplicationTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork<DVAInvestContext>>();
            _usuarioServiceMock = new Mock<IUsuarioService<DVAInvestContext>>();
            _usuarioApplication = new UsuarioApplication<DVAInvestContext>(_unitOfWorkMock.Object, _usuarioServiceMock.Object);
        }

        [Fact(DisplayName = "SaveAsync deve salvar usuário e realizar commit")]
        public async Task SaveAsync_DeveSalvarUsuarioERealizarCommit()
        {
            // Arrange
            var usuario = new Usuario("Vinicius", "vinicius@gmail.com", "123456") { Id = 1 };
            _usuarioServiceMock.Setup(s => s.SaveAsync(usuario)).ReturnsAsync(usuario);

            // Act
            var result = await _usuarioApplication.SaveAsync(usuario);

            // Assert
            _usuarioServiceMock.Verify(s => s.SaveAsync(usuario), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(usuario);
        }

        [Fact(DisplayName = "UpdateAsync deve atualizar usuário e realizar commit")]
        public async Task UpdateAsync_DeveAtualizarUsuarioERealizarCommit()
        {
            // Arrange
            var usuario = new Usuario("Vinicius", "vinicius@gmail.com", "123456") { Id = 1 };
            _usuarioServiceMock.Setup(s => s.UpdateAsync(usuario)).ReturnsAsync(usuario);

            // Act
            var result = await _usuarioApplication.UpdateAsync(usuario);

            // Assert
            _usuarioServiceMock.Verify(s => s.UpdateAsync(usuario), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(usuario);
        }
    }
}
