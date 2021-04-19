using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;
using Wba.PE1.Webshop.Web.Models;

namespace Wba.PE1.Webshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItemRepository itemRepository;

        public HomeController()
        {
            itemRepository = new ItemRepository();
        }

        [Route("/")]
        [Route("home")]
        [Route("home/index")]
        public IActionResult Index()
        {
            //decl viemodel
            var viewModel = new HomeIndexVm();

            viewModel.Items = itemRepository.GetItems();
            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
