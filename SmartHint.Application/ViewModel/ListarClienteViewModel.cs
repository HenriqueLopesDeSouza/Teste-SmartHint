using System.ComponentModel.DataAnnotations;

namespace SmartHint.Application.ViewModel
{
    public class ListarClienteViewModel
    {
        public int Id { get; set; }
        public string? NomeRazaoSocial { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataCadastro { get; set; }
        public bool? Bloqueado { get; set; }
    }
}