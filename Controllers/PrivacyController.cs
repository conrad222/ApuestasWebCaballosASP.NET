using ApuestasWebCaballos.Models.DataAcces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using System.Collections;
using System.Web;

namespace ApuestasWebCaballos.Controllers
{
    public class PrivacyController : Controller
    {
        // GET: PrivacyController
        public ActionResult Index()
        {
            bool estaLogueado = Convert.ToBoolean(HttpContext.Session.GetString("EstaLogueado"));

            if (estaLogueado)
            {
                // Establecer la variable de sesión para indicar que el usuario está logueado
                HttpContext.Session.SetString("EstaLogueado", "true");

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home"); // Redirigir al login si el usuario no está logueado
            }
        }

        // GET: PrivacyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrivacyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrivacyController/Create
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

        // GET: PrivacyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrivacyController/Edit/5
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

        // GET: PrivacyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrivacyController/Delete/5
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
