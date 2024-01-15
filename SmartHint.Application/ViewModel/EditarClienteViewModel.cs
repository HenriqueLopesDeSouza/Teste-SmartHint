using System.ComponentModel.DataAnnotations;

namespace SmartHint.Application.ViewModel
{
    public class EditarClienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(150, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo E-Mail é obrigatório.")]
        [StringLength(150, ErrorMessage = "O campo E-Mail deve ter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "O campo E-Mail deve ser um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [RegularExpression(@"^\d{11}$|^\(\d{2}\) \d{5}-\d{4}$", ErrorMessage = "Por favor, insira um número de celular válido.")]
        [DisplayFormat(DataFormatString = "{0:(##) #####-####}", ApplyFormatInEditMode = true)]
        public string Telefone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataCadastro { get; set; }

    }
}
