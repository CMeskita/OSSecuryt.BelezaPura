using Microsoft.EntityFrameworkCore;
using OSSecuryt.BelezaPura.Domain.Entity;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Infra.Data.DbSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Infra.Repository
{
    public class ServicosRepository : IServicosRepository
    {
        private readonly SqlServerContext _context;

        public ServicosRepository(SqlServerContext context)
        {
            _context = context;
        }

        public async Task<Servicos> FindServicosCliente(string cliente)
        {
            return await _context.Servicos.FirstAsync(x => x.ClienteNome == cliente);
        }
        public async Task<Servicos> FindServicosCelular(string celular)
        {
            return await _context.Servicos.FirstAsync(x => x.ClienteCelular == celular);
        }

        public async Task SaveAllAsync(IList<Servicos> servicos)
        {
           

            await _context.AddRangeAsync(servicos);

            await _context.SaveChangesAsync();
        }

        public async Task Remove(Guid id)
        {
            Servicos servicos = new Servicos(id);
            _context.Remove(servicos);
            await _context.SaveChangesAsync();
        }

        public async Task Save(Servicos servicos)
        {
            _context.Servicos.Add(servicos);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Servicos servicos)
        {

            _context.Update(servicos);
            await _context.SaveChangesAsync();

        }

        public async Task<List<Efeitos>> GetAllAsync()
        {
            return await _context.Efeitos.ToListAsync();
        }

    }
}
