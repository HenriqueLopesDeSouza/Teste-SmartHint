using SmartHint.Application.IService;
using SmartHint.Application.ViewModel;
using SmartHint.Core.Entities;
using SmartHint.Core.Enum;
using SmartHint.Core.IRepositories;
using System.Security.Cryptography;
using System.Text;

namespace SmartHint.Application.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<ListarClienteViewModel>> ListarAsync()
        {
            List<Cliente> clientes = await _clienteRepository.GetAllAsync();
            return MapParaListagem(clientes);
        }

        public async Task<EditarClienteViewModel> Editar(int clienteId)
        {
            Cliente cliente = await _clienteRepository.ObterClientePorIdAsync(clienteId);
            return MapParaEditar(cliente);
        }

        public async Task<List<ListarClienteViewModel>> FiltrarClientes(ListarClienteViewModel listar)
        {
            List<Cliente> lista = await _clienteRepository.FiltrarClientesAsync(MapParaFiltroListagem(listar));
            return MapParaListagem(lista);
        }


        public async Task<bool> InserirClienteAsync(CadastrarClienteViewModel model)
        {
            Cliente cliente = MapParaInserirCliente(model);

            cliente.Senha = ComputeSha256Hash(cliente.Senha);

            await _clienteRepository.InserirClienteAsync(cliente);

            return true;
        }


        #region Validações
        public string VerificarInscricaoEstadual(CadastrarClienteViewModel model)
        {
            bool isFisica = model.TipoPessoa == TipoPessoa.Fisica;
            bool isJuridica = model.TipoPessoa == TipoPessoa.Juridica;

            if (isFisica && string.IsNullOrWhiteSpace(model.InscricaoEstadual) && !model.Isento)
            {
                return "Inscrição estadual para Pessoa Física está ativa, marque insento se assim o for";
            }

            if (isJuridica && string.IsNullOrWhiteSpace(model.InscricaoEstadual))
            {
                return "A Inscrição Estadual é obrigatória para Pessoa Jurídica.";
            }
            return null;

        }

        public async Task<string> ValidacaoAsync(CadastrarClienteViewModel model)
        {
            bool isFisica = model.TipoPessoa == TipoPessoa.Fisica;
            bool isJuridica = model.TipoPessoa == TipoPessoa.Juridica;

            bool emailExistente = await _clienteRepository.CheckIfEmailExistsAsync(model.Email);
            if (emailExistente)
            {
                return "Este e-mail já está cadastrado para outro Cliente";
            }

            bool cpfCnpjExistente = await _clienteRepository.CheckIfCpfExistsAsync(model.CpfCnpj);
            if (cpfCnpjExistente)
            {
                return "Este CPF/CNPJ já está cadastrado para outro Cliente";
            }

            if (isJuridica || (isFisica && !model.Isento))
            {
                bool inscricaoEstadualExistente = await _clienteRepository.CheckIfInscricaoEstadualExistsAsync(model.InscricaoEstadual);
                if (inscricaoEstadualExistente)
                {
                    return "Esta Inscrição Estadual já está cadastrada para outro Cliente";
                }
            }

            return null;
        }
        #endregion

        #region Map
        private EditarClienteViewModel MapParaEditar(Cliente cliente)
        {
            return cliente != null ? new EditarClienteViewModel
            {
                Nome = cliente.NomeRazaoSocial,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                DataCadastro = cliente.DataCadastro,
            } : new EditarClienteViewModel();
        }

        private Cliente MapParaFiltroListagem(ListarClienteViewModel filtro)
        {
            return filtro != null ? new Cliente
            {
                NomeRazaoSocial = filtro.NomeRazaoSocial,
                Email = filtro.Email,
                Telefone = filtro.Telefone,
                DataCadastro = filtro.DataCadastro,
                Bloqueado = filtro.Bloqueado
            } : new Cliente();
        }

        private List<ListarClienteViewModel> MapParaListagem(List<Cliente> clientes)
        {
            return (clientes != null && clientes.Count > 0)
              ? clientes.Select(cliente => new ListarClienteViewModel
                {
                    Id = cliente.Id,
                    NomeRazaoSocial = cliente.NomeRazaoSocial,
                    Email = cliente.Email,
                    Telefone = cliente.Telefone,
                    DataCadastro = cliente.DataCadastro?.Date ?? DateTime.MinValue,
                    Bloqueado = cliente.Bloqueado
                }).ToList()
              : new List<ListarClienteViewModel>();
        }

        private static Cliente MapParaInserirCliente(CadastrarClienteViewModel viewModel)
        {
            return viewModel != null ? new Cliente
            {
                NomeRazaoSocial = viewModel.Nome,
                Email = viewModel.Email,
                Telefone = viewModel.Telefone,
                DataCadastro = viewModel.DataCadastro,
                Bloqueado = viewModel.Bloqueado,
                Senha = viewModel.Senha,
                TipoPessoa = viewModel.TipoPessoa.GetValueOrDefault(),
                CpfCnpj = viewModel.CpfCnpj,
                InscricaoEstadual = viewModel.InscricaoEstadual,
                Isento = viewModel.Isento,
                Genero = viewModel.Genero,
                DataNascimento = viewModel.DataNascimento
            } : new Cliente();
        }
        #endregion

        private string ComputeSha256Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                string senha = builder.ToString();
                return senha;
            }
        }

    }
}
