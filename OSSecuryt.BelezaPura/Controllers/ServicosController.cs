using MediatR;
using Microsoft.AspNetCore.Mvc;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Servico.Servico.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Controllers
{
    public class ServicosController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IServicosRepository _repository;
        public ServicosController(IMediator mediator, IServicosRepository repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
          ViewBag.Efeitos= await _repository.GetAllAsync();
           return View();
        }
        public async Task<IActionResult> CadastrarServico(ServicosCommand comand)
        {
            var response = await _mediator.Send(comand);
            return RedirectToAction("Index", "Home");
        }
    }
}
