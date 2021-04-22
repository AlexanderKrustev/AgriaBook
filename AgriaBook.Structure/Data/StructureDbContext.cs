namespace AgriaBook.Structure.Data
{
    using Microsoft.EntityFrameworkCore;

    public class StructureDbContext : DbContext
    {
        public StructureDbContext(DbContextOptions<StructureDbContext> options):
            base(options)
        {
                
        }


    }
}
