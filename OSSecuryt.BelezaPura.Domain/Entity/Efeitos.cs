using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Domain.Entity
{
    public class Efeitos
    {
    
        public Efeitos(string descricao)
        {
            Descricao = descricao;
        }

        //public Efeitos(Guid id)
        //{
        //    Id = id;
        //}

        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public virtual IList<Servicos> Servicos { get; set; }
        public List<BrokenRule> Errors { get; protected set; }

        public bool HasErrors => Errors.Count > 0;

        public void AddBrokenRule(string field, string description)
        {
            BrokenRule rule = new BrokenRule(field, description);
            Errors.Add(rule);
        }
    }
   
}
