using System.ComponentModel.DataAnnotations;

namespace ProjetoFidelidade.Web.ViewModels
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [MinLength(2, ErrorMessage = "O DDD deve conter 2 digitos.")]
        [MaxLength(2, ErrorMessage = "O DDD deve conter 2 digitos.")]
        [Display(Name = "DDD")]
        public string DddCelular { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [MinLength(8, ErrorMessage = "O Celular deve conter no mínimo 8 digitos.")]
        [MaxLength(9, ErrorMessage = "O Celular deve conter no máximo 9 digitos.")]
        public string Celular { get; set; }
    }
}