using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BDMVCnet7;

namespace MVCnet7.Controllers
{
    public class AFILIACIONController : Controller
    {
        // GET: AFILIACIONController
        private readonly IConfiguration _configuration;
        public AFILIACIONController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        
        {
            var server = _configuration["Server"];
            var catalog = _configuration["Catalog"];
            var usuario = _configuration["Usuario"];
            var pass = _configuration["Password"];
            DataBase dbConnection = new DataBase(server,catalog,usuario,pass);
            //dbConnection.GetListAfiliacion();
            return View(dbConnection.GetListAfiliacion());
        }

        // GET: AFILIACIONController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AFILIACIONController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AFILIACIONController/Create
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

        // GET: AFILIACIONController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AFILIACIONController/Edit/5
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

        // GET: AFILIACIONController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AFILIACIONController/Delete/5
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
