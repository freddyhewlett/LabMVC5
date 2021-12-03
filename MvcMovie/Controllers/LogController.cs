using MvcMovie.Filters;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class LogController : Controller
    {

        private MovieDBContext logDb = new MovieDBContext();

        //[Authorize(Users = "admin@mvc.br")]
        [Authorize]
        [LogActionFilter]
        // GET: Log
        public ActionResult Index()
        {
            var log = logDb.Log.OrderBy(d => d.Date).ToList();
            return View(log);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                logDb.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}