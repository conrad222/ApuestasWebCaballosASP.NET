using ApuestasWebCaballos.Models.DataAcces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using System.Web;

namespace ApuestasWebCaballos.Controllers
{
    public class ApuestasController : Controller
    {
        // GET: ApuestasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApuestasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApuestasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApuestasController/Create
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

        // GET: ApuestasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApuestasController/Edit/5
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

        // GET: ApuestasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApuestasController/Delete/5
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
