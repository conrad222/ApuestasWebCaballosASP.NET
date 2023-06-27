using ApuestasWebCaballos.Models.DataAcces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using System.Web;

namespace ApuestasWebCaballos.Controllers
{
    public class UserController : Controller
    {
        private readonly CarreraswebContext db = new CarreraswebContext();

        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(CarreraswebContext context, IHttpContextAccessor httpContextAccessor)
        {
            db = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(string usuario, string correo, string clave, double dinero)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Name = usuario,
                Email = correo,
                Password = clave,
                Dinero = dinero

            };

            db.Usuarios.Add(nuevoUsuario);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string correo, string clave)
        {
            Usuario usuario = db.Usuarios.FirstOrDefault(u => u.Email == correo && u.Password == clave);

            if (usuario != null)
            {
                _httpContextAccessor.HttpContext.Session.SetInt32("usuario_id", usuario.Id);

                return RedirectToAction("Index", "Privacy");
            }

            ModelState.AddModelError("", "Correo o contraseña incorrectos");

            return View();
        }


        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
