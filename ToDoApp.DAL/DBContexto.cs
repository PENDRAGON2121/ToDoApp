using Microsoft.EntityFrameworkCore;
using ToDoApp.Model;

namespace ToDoApp.DAL
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto> opciones) : base(opciones)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}