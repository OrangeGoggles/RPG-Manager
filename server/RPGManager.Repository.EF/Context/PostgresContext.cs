using Microsoft.EntityFrameworkCore;
using RPGManager.Repository.EF.Mappings;

namespace RPGManager.Repository.EF.Context
{
    public class PostgresContext : DbContext
    {
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new CharacterSheetMap());
        }
    }
}