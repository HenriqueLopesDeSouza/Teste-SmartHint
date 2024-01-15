using SmartHint.Application.ViewModel;

namespace SmartHint.Application.IService
{
    public interface IClienteService
    {
        Task<List<ListarClienteViewModel>> ListarAsync();
        Task<string> ValidacaoAsync(CadastrarClienteViewModel model);
        Task<bool> InserirClienteAsync(CadastrarClienteViewModel model);
        string VerificarInscricaoEstadual(CadastrarClienteViewModel model);
        Task<EditarClienteViewModel> Editar(int clienteId);
        Task<List<ListarClienteViewModel>> FiltrarClientes(ListarClienteViewModel model);
    }
}
