using MediatR;
using OSSecuryt.BelezaPura.Servico.Util;

namespace OSSecuryt.BelezaPura.Servico.Efeito.Commands
{
    public class EfeitosCommand: IRequest<Response>
    {
        public string Descricao { get; set; }
    }
}
