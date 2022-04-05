using MediatR;
using Microsoft.AspNetCore.Mvc;
using OSSecuryt.BelezaPura.Servico.Efeito.Commands;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Controllers
{
    public class EfeitosController : Controller
    {
        private readonly IMediator _mediator;

        public EfeitosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> CadastrarEfeitos(EfeitosCommand comand)
        {
            var response = await _mediator.Send(comand);
            return RedirectToAction("Index", "Home");
        }

    }
}
