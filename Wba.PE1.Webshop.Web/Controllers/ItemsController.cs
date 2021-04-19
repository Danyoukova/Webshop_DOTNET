using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;

namespace pe1.Webshop.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ItemRepository itemRepository;

        public ItemsController()
        {
            itemRepository = new ItemRepository();
        }

        [Route("items")]
        [Route("items/index")]
        [Route("items/all")]
        public IActionResult Index()
        {
            var viewModel = new ItemsIndexVm();
            viewModel.Items = itemRepository.GetItems();

            return View(viewModel);
        }

        [Route("items/{id}")]
        public IActionResult ShowItem(int id)
        {
            var item = itemRepository.GetItems().FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();

            var viewModel = new ItemsShowItemVm();
            viewModel.Item = item;

            return View(viewModel);
        }

    }
}
