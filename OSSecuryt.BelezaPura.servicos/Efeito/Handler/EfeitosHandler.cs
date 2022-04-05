using MediatR;
using OSSecuryt.BelezaPura.Domain.Entity;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Servico.Util;
using OSSecuryt.BelezaPura.Servico.Efeito.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Servico.Efeito.Handler
{
    public class EfeitosHandler : IRequestHandler<EfeitosCommand, Response>
    {
        IEfeitosRepository _repository;
        private readonly IUnityOfWork _unitOfWork;

        public EfeitosHandler(IEfeitosRepository repository, IUnityOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(EfeitosCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Efeitos efeito = new Efeitos(request.Descricao);
                _unitOfWork.BeginTransaction();
                await _repository.Save(efeito);
                _unitOfWork.Commit();
                return new Response
                {
                    Message = "Efeito registrado com sucesso!!!",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    Message = "Ocorreu um erro ao salver o Efeito: " + ex.Message,
                    StatusCode = 500
                };
            }
        }
    }
}
