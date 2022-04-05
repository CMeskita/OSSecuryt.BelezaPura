using MediatR;
using OSSecuryt.BelezaPura.Servico.Util;
using System;


namespace OSSecuryt.BelezaPura.Servico.Servico.Commands
{
    public class ServicosCommand : IRequest<Response>
    {
        public string ClienteNome { get; set; }

        public string ClienteCelular { get; set; }
        public string NomeServico { get; set; }

        public DateTime DataServicos { get; set; }

        public Guid IdEfeitos { get; set; }       

        public string BodyPart { get; set; }

        public string Tipo { get; set; }

        public double Valor { get; set; }
    }
}
