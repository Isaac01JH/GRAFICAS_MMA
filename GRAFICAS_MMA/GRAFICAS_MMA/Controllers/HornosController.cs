using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GRAFICAS_MMA.Controllers
{
    public class HornosController : Controller
    {
        // GET: HornosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HornosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HornosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HornosController/Create
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

        // GET: HornosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HornosController/Edit/5
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

        // GET: HornosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HornosController/Delete/5
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
