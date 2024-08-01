using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DVAInvest.Domain.Entities;

namespace DVAInvest.Web.Models;

public class EstoqueViewModel
{
    public int Id { get; set; }

    [DisplayName("Nome")]
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MaxLength(50, ErrorMessage = "O campo Nome deve ter até 50 caracteres")]
    [MinLength(5, ErrorMessage = "O campo Nome deve ter no mínimo 5 caracteres")]
    public string Nome { get; set; } = string.Empty;
    
}
