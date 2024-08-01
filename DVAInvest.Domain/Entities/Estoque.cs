using DVAInvest.Domain.Entities.Base;
using DVAInvest.Domain.Exceptions;
using DVAInvest.Domain.Exceptions.Base;

namespace DVAInvest.Domain.Entities;

public class Estoque : EntityBase
{
    public string Nome { get; set; }

    public Estoque(string nome)
    {
        Nome = nome;
        ValidarNome();
    }

    protected Estoque() { }

    private void ValidarNome()
    {
        string msg = string.Empty;

        if(string.IsNullOrEmpty(Nome))
        {
            msg = "O Nome deve ser preenchido";
            throw new Exception(msg);
        }

        if(Nome.Length <= 5 && Nome.Length >= 50)
        {
            msg = "O Nome deve ter entre 5 e 50 caracteres";
            throw new Exception(msg);
        }
    }
}
