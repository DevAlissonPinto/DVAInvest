using DVAInvest.Domain.Entities.Base;

namespace DVAInvest.Domain.Entities;

public class Material : EntityBase
{
    public string Nome { get; set; }
    public string Codigo { get; set; }

    public Material(string nome, string codigo)
    {
        Nome = nome;
        Codigo = codigo;

        Validar();
    }

    private void ValidarNome()
    {
        string msg = string.Empty;

        if (string.IsNullOrEmpty(Nome))
        {
            msg = "O Nome deve ser preenchido";
            throw new Exception(msg);
        }

        if (Nome.Length <= 5 && Nome.Length >= 100)
        {
            msg = "O Nome deve ter entre 5 e 100 caracteres";
            throw new Exception(msg);
        }
    }

    private void ValidarCodigo()
    {
        string msg = string.Empty;

        if (string.IsNullOrEmpty(Codigo))
        {
            msg = "O Código deve ser preenchido";
            throw new Exception(msg);
        }

        if (Codigo.Length <= 2 && Nome.Length >= 10)
        {
            msg = "O Código deve ter entre 2 e 10 caracteres";
            throw new Exception(msg);
        }
    }

    private void Validar()
    {
        ValidarNome();
        ValidarCodigo();
    }

}
