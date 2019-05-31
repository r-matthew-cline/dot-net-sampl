using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PickEm.Web.Controllers
{
    public class BracketBuilderController : Controller
    {
        //
        // GET: /BracketBuilder/

        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /BracketBuilder/ViewBracket/

        public IActionResult ViewBracket()
        {
            return View();
        }
    }
}