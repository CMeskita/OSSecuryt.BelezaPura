using Microsoft.EntityFrameworkCore.Storage;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Infra.Data.DbSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Infra.UnitOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly SqlServerContext _context;
        private IDbContextTransaction _transaction;

        public UnityOfWork(SqlServerContext context)
        {
            _context = context;
        }
        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }
    }
}
