using Microsoft.EntityFrameworkCore;

namespace APIwithControllers.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) 
            : base(options)
        {
            
        }
        
        //null!
        //By using the null-forgiving operator,
        //you inform the compiler that passing null is expected and shouldn't be warned about.
        public DbSet<TodoItem> To { get; set; } = null!;
    }
}