using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class Tarea
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public string Descripcion { get; set; }
        public Estado estado { get; set; }
        public Prioridad prioridad { get; set; }
    }
}
