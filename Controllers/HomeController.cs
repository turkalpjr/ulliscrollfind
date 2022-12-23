using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using testscroll.Model;

namespace testscroll.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _PopulatePartial()
        {
            List<Model1> L = new List<Model1>();
            for (int i = 1; i < 200; i++)
            {
                Model1 M = new Model1()
                {
                    Id=i,
                    Text="TESTTEXT"+i
                };
                L.Add(M);
            }
            return PartialView(L);
        }
    }
}
