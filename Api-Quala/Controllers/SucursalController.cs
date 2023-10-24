using Api_Quala.Contexts;
using Api_Quala.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Quala.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SucursalController : Controller
    {
        private readonly ConexionDB db;

        public SucursalController(ConexionDB db)
        {
            this.db = db;
        }

        // GET: SucursalController
        [HttpGet]
        [Route("Lista-sucursales")]
        public IEnumerable<SucursalModel> GetValuesSucursales()
        {
            return db.sucursalModels.ToList();
        }

        [HttpGet]
        [Route("Lista-monedas")]
        public IEnumerable<MonedaModel> GetValuesMonedas()
        {
            return db.monedaModels.ToList();
        }

        // GET: SucursalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SucursalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SucursalController/Create
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

        // GET: SucursalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SucursalController/Edit/5
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

        // GET: SucursalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SucursalController/Delete/5
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
