using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class DataInitializer
    {
        public void InitializeDatabase(ApplicationDbContext context)
        {
            context.Database.Migrate();
        }
    }
}