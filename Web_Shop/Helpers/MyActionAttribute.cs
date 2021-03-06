using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Shop.Helpers
{
    public class MyActionAttribute : FilterAttribute, IActionFilter
    {
        // Before
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //! YOUR ANY CODE

            if (filterContext.HttpContext.Request.Browser.Browser == "Firefox")//Opera Firefox Chrome
            {
                filterContext.Result = new HttpNotFoundResult();
            }

        }

        // After
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //! YOUR ANY CODE
            filterContext.HttpContext.Response.Write("Действие выполнено");


        }

    }
}