using Microsoft.EntityFrameworkCore;
using skilltech.Models;

namespace skilltech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<contatoModel> contatoModels { get; set; }
        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<AdmRootModel> AdmRootModels { get; set; }

    }
}
