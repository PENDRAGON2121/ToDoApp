using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class Tarea
    {
        // Propiedades de la clase
        [Key]
        public int ID { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public Estado? Estado { get; set; }
        public Prioridad? Prioridad { get; set; }
    }
}
