using OSSecuryt.BelezaPura.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Domain.Interfaces
{
    public interface IServicosRepository
    {
        Task<Servicos> FindServicosCliente(string cliente);
        Task<Servicos> FindServicosCelular(string celular);
        Task<List<Efeitos>> GetAllAsync();
        Task Save(Servicos servicos);
        Task SaveAllAsync(IList<Servicos> servicos);
        Task Update(Servicos servicos);
        Task Remove(Guid id);

    }
}
