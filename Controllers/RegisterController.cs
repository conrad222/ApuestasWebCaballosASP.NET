using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApuestasWebCaballos.Models;
using ApuestasWebCaballos.Models.DataAcces;

namespace ApuestasWebCaballos.Controllers
{
    public class RegisterController : Controller
    {
        // GET: RegisterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegisterController/Details/5
        [HttpPost]
        public ActionResult Index(Usuario usuario, string confirmPassword)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Password != confirmPassword)
                {
                    ModelState.AddModelError("confirmPassword", "Las contraseñas no coinciden.");
                    return View(usuario);
                }

                using (var context = new CarreraswebContext())
                {
                    // Comprobar que el email no se encuentra ya registrado
                    if (context.Usuarios.Any(u => u.Email == usuario.Email))
                    {
                        ModelState.AddModelError("Email", "Ya existe un usuario con este email.");
                        return View(usuario);
                    }

                    // Añadir el rol al usuario
                    usuario.RoleId = context.Rols.SingleOrDefault(r => r.Name == "Usuario").Id;
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
            }

            return View(usuario);
        }

        // POST: RegisterController/Create
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

        // GET: RegisterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterController/Edit/5
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

        // GET: RegisterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterController/Delete/5
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
