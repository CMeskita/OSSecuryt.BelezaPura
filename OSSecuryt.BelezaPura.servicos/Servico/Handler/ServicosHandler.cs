using MediatR;
using OSSecuryt.BelezaPura.Domain.Entity;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Servico.Util;
using OSSecuryt.BelezaPura.Servico.Servico.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Servico.Servico.Handler
{
    public class ServicosHandler : IRequestHandler<ServicosCommand, Response>
    {
        IServicosRepository _repository;
        private readonly IUnityOfWork _unitOfWork;

        public ServicosHandler(IServicosRepository repository, IUnityOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }



        public async Task<Response> Handle(ServicosCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Servicos servico = new Servicos(request.ClienteNome, request.ClienteCelular, request.NomeServico, request.DataServicos, request.IdEfeitos, request.Tipo, request.BodyPart, request.Valor);
                _unitOfWork.BeginTransaction();
                await _repository.Save(servico);
                _unitOfWork.Commit();
                return new Response
                {
                    Message = "Serviço registrado com sucesso!!!",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    Message = "Ocorreu um erro ao salver o Servico: " + ex.Message,
                    StatusCode = 500
                };
            }
        }
    }
}
