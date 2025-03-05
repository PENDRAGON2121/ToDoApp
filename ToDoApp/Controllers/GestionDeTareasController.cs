using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.BL;
using ToDoApp.DAL;
using ToDoApp.Model;

namespace ToDoApp.Controllers
{
    public class GestionDeTareasController : Controller
    {
        private GestorDeLasTareas _gestorDeLasTareas;

        public GestionDeTareasController(DBContexto conexion)
        {
            _gestorDeLasTareas = new GestorDeLasTareas(conexion);
        }


        // GET: GestionDeTareasController
        public ActionResult Index()
        {
            List<Model.Tarea> tareas = _gestorDeLasTareas.ObtengaLaListaDeTareas();
            return View(tareas);
        }

        // GET: GestionDeTareasController/Details/5
        public ActionResult Details(int id)
        {
            Model.Tarea detalleTarea;
            detalleTarea = _gestorDeLasTareas.ObtenerUnaTareaPorID(id);

            if (detalleTarea == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(detalleTarea);
        }

        // GET: GestionDeTareasController/Create
        public ActionResult Create()
        {
            Tarea tarea = new Tarea();

            return View(tarea);
        }

        // POST: GestionDeTareasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tarea Tarea)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gestorDeLasTareas.AgregarTarea(Tarea);
                    return RedirectToAction(nameof(Index));
                }

                return View(Tarea);
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionDeTareasController/Edit/5
        public ActionResult Edit(int id)
        {
            Tarea tarea;
            tarea = _gestorDeLasTareas.ObtenerUnaTareaPorID(id);
            if (tarea == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(tarea);
        }

        // POST: GestionDeTareasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tarea collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Index));
                }
                
                _gestorDeLasTareas.ActualizarTarea(collection);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: GestionDeTareasController/Delete/5
        public ActionResult Delete(int id)
        {
            Tarea tarea;
            tarea=_gestorDeLasTareas.ObtenerUnaTareaPorID(id);

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(tarea);
        }

        // POST: GestionDeTareasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id, Tarea collection)
        {
            try
            {
                _gestorDeLasTareas.EliminarTareaPorID(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
