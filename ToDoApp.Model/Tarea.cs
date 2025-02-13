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
        [Required]
        public string? Titulo { get; set; }
        [Required]
        public string? Descripcion { get; set; }
        [Required]
        public Estado? Estado { get; set; }
        [Required]
        public Prioridad? Prioridad { get; set; }
    }
}
