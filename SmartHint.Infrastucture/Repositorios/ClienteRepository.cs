using Microsoft.EntityFrameworkCore;
using SmartHint.Core.Entities;
using SmartHint.Core.IRepositories;

namespace SmartHint.Infrastucture.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SmartHintDbContext _dbContext;

        public ClienteRepository(SmartHintDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            return await _dbContext.Clientes.ToListAsync();
        }

        public async Task<bool> CheckIfEmailExistsAsync(string email)
        {
            return await _dbContext.Clientes.AnyAsync(e => e.Email == email);
        }

        public async Task<bool> CheckIfCpfExistsAsync(string cpfCnpj)
        {
            return await _dbContext.Clientes.AnyAsync(c => c.CpfCnpj == cpfCnpj);
        }

        public async Task<bool> CheckIfInscricaoEstadualExistsAsync(string inscricaoEstadual)
        {
            return await _dbContext.Clientes.AnyAsync(c => c.InscricaoEstadual == inscricaoEstadual);
        }

        public async Task InserirClienteAsync(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<Cliente> ObterClientePorIdAsync(int clienteId)
        {
            return await _dbContext.Clientes.FirstOrDefaultAsync(c => c.Id == clienteId);
        }

        public async Task<List<Cliente>> FiltrarClientesAsync(Cliente filtro)
        {
            var query = _dbContext.Clientes
                .Where(c =>
                    (string.IsNullOrEmpty(filtro.NomeRazaoSocial) || c.NomeRazaoSocial.Contains(filtro.NomeRazaoSocial)) &&
                    (string.IsNullOrEmpty(filtro.Email) || c.Email.Contains(filtro.Email)) &&
                    (string.IsNullOrEmpty(filtro.Telefone) || c.Telefone.Contains(filtro.Telefone)) &&
                    (filtro.DataCadastro == null || c.DataCadastro.Value.Date == filtro.DataCadastro.Value.Date) &&
                    (filtro.Bloqueado == null || c.Bloqueado.Value == filtro.Bloqueado)
                );

            return await query.ToListAsync();
        }

    }
}
