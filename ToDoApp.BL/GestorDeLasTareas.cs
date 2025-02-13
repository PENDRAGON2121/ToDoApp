using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DAL;

namespace ToDoApp.BL
{
    public class GestorDeLasTareas
    {
        public readonly DBContexto conexion;
        
        private List<Model.Tarea> ListaDeTareas = new List<Model.Tarea>();

        public GestorDeLasTareas(DBContexto contexto)
        {
            conexion = contexto;
        }

        public List<Model.Tarea> ObtengaLaListaDeTareas()
        {
            foreach (var item in conexion.Tareas) 
            {
                ListaDeTareas.Add(new Model.Tarea
                {
                    ID = item.ID,
                    Titulo = item.Titulo,
                    Descripcion = item.Descripcion,
                    Estado = item.Estado,
                    Prioridad = item.Prioridad
                });
            }

            return ListaDeTareas;
        }
    }
}
