﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            //base.HandleUnknownAction(actionName);

            RedirectToAction("Index")
                .ExecuteResult(this.ControllerContext);
        }
    }
}