using Microsoft.EntityFrameworkCore;
using SqlNoSql.Core.Entities;

namespace SqlNoSql.Sql.Configuration
{
    public class DbSqlContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSqlContext(DbContextOptions options): base(options)
        {

        }
    }
}
