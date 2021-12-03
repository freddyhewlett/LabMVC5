using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        private MovieDBContext logDbContext = new MovieDBContext();


        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    LogModel log = new LogModel(filterContext.HttpContext.User.Identity.Name, filterContext.ActionDescriptor.ActionName);
        //    logDbContext.Log.Add(log);
        //    logDbContext.SaveChanges();
        //}

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogModel log = new LogModel(filterContext.HttpContext.User.Identity.Name, filterContext.ActionDescriptor.ActionName);
            logDbContext.Log.Add(log);
            logDbContext.SaveChanges();
            //filterContext.Controller.ViewBag.Executed = $"Action {filterContext.ActionDescriptor.ActionName} ended execution at {DateTime.Now.ToLongTimeString()}";
            
        }
    }
}