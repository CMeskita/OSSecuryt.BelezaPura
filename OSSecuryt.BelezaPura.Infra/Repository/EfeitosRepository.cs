using Microsoft.EntityFrameworkCore;
using OSSecuryt.BelezaPura.Domain.Entity;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Infra.Data.DbSqlServer;
using System;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Infra.Repository
{
    public class EfeitosRepository : IEfeitosRepository
    {
        private readonly SqlServerContext _context;

        public EfeitosRepository(SqlServerContext context)
        {
            _context = context;
        }
        public async Task<Efeitos> FindUserByDescricao(string descricacao)
        {
            return await _context.Efeitos.FirstAsync(x => x.Descricao == descricacao);
        }
    
        //public async Task Remove(Guid id)
        //{
        //    Efeitos efeitos = new Efeitos(id);
        //    _context.Remove(efeitos);
        //    await _context.SaveChangesAsync();
        //}

        public async Task Save(Efeitos efeitos)
        {
            _context.Efeitos.Add(efeitos);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Efeitos efeitos)
        {

            _context.Update(efeitos);
            await _context.SaveChangesAsync();

        }
    }
}
