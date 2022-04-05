using Microsoft.EntityFrameworkCore;
using OSSecuryt.BelezaPura.Domain.Entity;
using OSSecuryt.BelezaPura.Infra.SqlMap;


namespace OSSecuryt.BelezaPura.Infra.Data.DbSqlServer
{
    public class SqlServerContext:DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) 
        {

        }

        public DbSet<Efeitos> Efeitos { get; set; }
        public DbSet<Servicos> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.ApplyConfiguration(new EfeitosMap());
            modelBuilder.ApplyConfiguration(new ServicosMap());
         

            base.OnModelCreating(modelBuilder);

        }

    }
}
