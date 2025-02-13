using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.BL;
using ToDoApp.DAL;

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

            return View(detalleTarea);
        }

        // GET: GestionDeTareasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionDeTareasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GestionDeTareasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionDeTareasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
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
            return View();
        }

        // POST: GestionDeTareasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
