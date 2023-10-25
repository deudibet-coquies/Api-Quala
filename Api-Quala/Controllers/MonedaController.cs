using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Quala.Controllers
{
    public class MonedaController : Controller
    {
        // GET: MonedaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MonedaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonedaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonedaController/Create
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

        // GET: MonedaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonedaController/Edit/5
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

        // GET: MonedaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonedaController/Delete/5
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
