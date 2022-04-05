using OSSecuryt.BelezaPura.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Domain.Interfaces
{
    public interface IEfeitosRepository
    {
        Task<Efeitos> FindUserByDescricao(string descricacao);
        Task Save(Efeitos efeitos);
        //Task Remove(Guid id);
        Task Update(Efeitos efeitos);
       
    }
}
