using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Domain.Entity
{
    public class Tipo
    {
        public Tipo()
        {
            Hidratacao = "Hidratação";
            Aplicacao = "Aplicação";
            Esmaltaria = "Esmataria";
            Avulso = "Avulso";
            Manutencao = "Manutenção";
        }

       
        public string Hidratacao { get; set; }
        public string  Aplicacao { get; set; }
        public string Esmaltaria { get; set; }
        public string Avulso { get; set; }
        public string Manutencao { get; set; }

        public virtual IList<Servicos> Servicos { get; set; }


    }
}
