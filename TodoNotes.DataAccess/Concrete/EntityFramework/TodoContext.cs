using System.Data.Entity;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.DataAccess.Concrete.EntityFramework
{
    public class TodoContext : DbContext
    {
        public TodoContext()
            : base("TodoConnection")
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Note> Notes { get; set; }

    }
}
