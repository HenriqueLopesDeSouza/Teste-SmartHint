using SmartHint.Core.Enum;
using System.ComponentModel.DataAnnotations;


namespace SmartHint.Application.ViewModel
{
    public class CadastrarClienteViewModel
    {
        public CadastrarClienteViewModel()
        {
            DataCadastro = DateTime.Today;
            Bloqueado = false;
        }

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
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar o tipo da pessoa.")]
        public TipoPessoa? TipoPessoa { get; set; }

        [Required(ErrorMessage = "O campo CPF/CNPJ é obrigatório.")]
        public string CpfCnpj { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{3}$", ErrorMessage = "Por favor, insira uma Inscrição Estadual válida.")]
        public string? InscricaoEstadual { get; set; }

        public bool Isento { get; set; }

        public Genero? Genero { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataNascimento { get; set; }

        public bool Bloqueado { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "A senha deve conter apenas letras e números.")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 15 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A confirmação de senha é obrigatória.")]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 15 caracteres.")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmacaoSenha { get; set; }


    }
}
