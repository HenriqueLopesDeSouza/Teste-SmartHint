using SmartHint.Core.Entities;

namespace SmartHint.Core.IRepositories
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetAllAsync();
        Task<bool> CheckIfEmailExistsAsync(string email);
        Task<bool> CheckIfCpfExistsAsync(string cpfCnpj);
        Task<bool> CheckIfInscricaoEstadualExistsAsync(string inscricaoEstadual);
        Task InserirClienteAsync(Cliente cliente);
        Task<Cliente> ObterClientePorIdAsync(int clienteId);
        Task<List<Cliente>> FiltrarClientesAsync(Cliente filtro);
    }
}
