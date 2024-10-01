using Microsoft.EntityFrameworkCore;

namespace NewsApp.Models

{
    public class NewContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
