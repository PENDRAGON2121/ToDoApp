using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DAL;
using ToDoApp.Model;

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
        public Tarea ObtenerUnaTareaPorID(int id) 
        {
            Tarea? tareaPorId = new Tarea();
            tareaPorId = conexion.Tareas.Find(id);

            return tareaPorId;
        }
        public String AgregarTarea(Tarea tarea)
        {
            
            conexion.Tareas.Add(tarea);
            conexion.SaveChanges();
            return "Tarea agregada";
        }

        public void EliminarTareaPorID(int id)
        {
            Tarea tarea;
            tarea = ObtenerUnaTareaPorID(id);
            conexion.Tareas.Remove(tarea);
            conexion.SaveChanges(true);
        }
        public void ActualizarTarea(Tarea tarea)
        {
            conexion.Tareas.Update(tarea);
            conexion.SaveChanges(true);
        }


    }
}
