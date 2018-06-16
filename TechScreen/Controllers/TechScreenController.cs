using System.Web;
using System.Web.Mvc;

namespace TechScreen.Controllers
{
    public class TechScreenController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome()
        {   
            return View();
        }
    }
}

