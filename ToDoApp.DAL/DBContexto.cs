using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
