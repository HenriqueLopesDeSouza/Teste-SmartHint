using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHint.Application.IService;
using SmartHint.Application.ViewModel;
using SmartHint.Core.Enum;

namespace SmartHint.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<ActionResult> Listar(ListarClienteViewModel model)
        {
            ConfigureViewBags();
            
            return View(model);
        }

      
        [HttpGet]
        public async Task<IActionResult> Grid(ListarClienteViewModel  model)
        {
            try {

                List<ListarClienteViewModel> listaModelos = await _clienteService.FiltrarClientes(model);
                return PartialView("_GridListagem", listaModelos);

            }
            catch(Exception ex) 
            {
                return PartialView("_GridListagem", new List<ListarClienteViewModel>());

            }
        }


        [Route("Cadastrar")]
        public async Task<IActionResult> Cadastrar()
        {
            ConfigureViewBags();
            return View(new CadastrarClienteViewModel());
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarClienteViewModel model)
        {
            try
            {
                ConfigureViewBags();

                if (!ModelState.IsValid)
                {
                    return View(model);
                }
              
                string validacaoInscricao = _clienteService.VerificarInscricaoEstadual(model);
                if (validacaoInscricao != null) 
                {
                    ModelState.AddModelError(nameof(model.InscricaoEstadual), validacaoInscricao);
                    return View(model);
                }

                string validacao = await _clienteService.ValidacaoAsync(model);

                if (validacao != null)
                {
                    TempData["message"] = validacao;
                    TempData["valortoastr"] = "error";
                    return View(model);
                }

                await _clienteService.InserirClienteAsync(model);


                TempData["message"] = "Criado";
                TempData["valortoastr"] = "success";

                return RedirectToAction("Listar");
            }
            catch (Exception ex)
            {
                TempData["message"] = "Ocorreu um erro ao inserir o cliente Erro: " + ex.Message;
                TempData["valortoastr"] = "error";
                return View(model);
            }
        }

        [Route("Editar/{id}")]
        public async Task<IActionResult> Editar(int id)
        {
            try 
            {
                var cliente = await _clienteService.Editar(id);

                if (cliente == null)
                {
                    TempData["message"] = "Cliente não encontrado";
                    TempData["valortoastr"] = "warning";
                    return RedirectToAction("Listar");
                }

                return View(cliente);
            }
            catch (Exception ex) 
            {
                TempData["message"] = ex.Message;
                TempData["valortoastr"] = "error";
                return RedirectToAction("Listar");
            }
        }

        private void ConfigureViewBags()
        {
            ViewBag.TiposDePessoa = new SelectList(Enum.GetValues(typeof(TipoPessoa)));
            ViewBag.Genero = new SelectList(Enum.GetValues(typeof(Genero)));
            ViewBag.Bloqueado = new List<SelectListItem>
            {
                new SelectListItem { Text = "SELECIONE", Value = null },
                new SelectListItem { Text = "NÃO", Value = "False" },
                new SelectListItem { Text = "SIM", Value = "True" }
            };
        }
    }   
}
