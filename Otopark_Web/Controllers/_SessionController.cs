using System.Web.Mvc;

namespace Otopark_Web.Controllers
{
    public class _SessionController : ActionFilterAttribute
    {
        // GET: _Session
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["Kullanici"] == null && filterContext.HttpContext.Request.Url.AbsolutePath == "/Login/Dashboard")
            {
                filterContext.HttpContext.Response.Redirect("/Login/LoginPage");
            }
            else if(filterContext.HttpContext.Session["Kullanici"] != null && filterContext.HttpContext.Request.Url.AbsolutePath == "/Login/LoginPage")
            {
                filterContext.HttpContext.Response.Redirect("/Login/Dashboard");
            }

        }
    }
}