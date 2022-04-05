using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Domain.Entity
{
    public class Servicos
    {

        private Guid id;

       

        public Servicos( Guid id)
        {
            this.id = id;
        }

        public Servicos(string clienteCelular, string nomeServico, string nomeServico1, DateTime dataServicos, Guid idEfeitos, string bodyPart, string tipo, double valor)
        {
            ClienteCelular = clienteCelular;
            NomeServico = nomeServico;
            DataServicos = dataServicos;
            IdEfeitos = idEfeitos;           
            BodyPart = bodyPart;
            Tipo = tipo;
            Valor = valor;
        }

        public Guid Id { get; set; }
        public string ClienteNome { get; set; }

        public string ClienteCelular { get; set; }
        public string NomeServico { get; set; }

        public DateTime DataServicos { get; set; }

        public Guid IdEfeitos { get; set; }
        public virtual Efeitos Efeitos { get; set; }

        public string BodyPart { get; set; }

        public string Tipo { get; set; }

        public double Valor { get; set; }

        public double ValorTotalServico { get; set; }

        public void CalcularTotalServicosGrid() 
        {
            Valor += Valor;
        }
        public void Manutencao() 
        {
        }
        public void CalcularServico() 
        {

        }
        public void CalcularEsmaltaria() 
        {
        }
        public void Aplicacao() 
        {
        }
        public List<BrokenRule> Errors { get; protected set; }

        public bool HasErrors => Errors.Count > 0;

        public void AddBrokenRule(string field, string description)
        {
            BrokenRule rule = new BrokenRule(field, description);
            Errors.Add(rule);
        }




    }
}
