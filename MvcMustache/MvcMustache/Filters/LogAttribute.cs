﻿using MvcMustache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMustache.Filters
{
    public class LogAttribute : FilterAttribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogVeri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IslemTarihi = DateTime.Now,
                Tip = "Sonra"
            });
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogVeri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IslemTarihi = DateTime.Now,
                Tip = "Önce"
            });
        }
    }
}