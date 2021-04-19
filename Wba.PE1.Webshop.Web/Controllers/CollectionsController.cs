using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;

namespace pe1.Webshop.Web.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly CollectionsRepository collectionsRepository;
        private readonly ItemRepository itemRepository;

        public CollectionsController()
        {
            collectionsRepository = new CollectionsRepository();
            itemRepository = new ItemRepository();
        }

        [Route("collections")]
        [Route("collections/index")]
        [Route("collections/all")]

        public IActionResult Index()
        {
            var viewModel = new CollectionsIndexVm();
            viewModel.Collections = collectionsRepository.GetCollections();

            return View(viewModel);
        }

        [Route("collections/{id}")]
        public IActionResult ShowCollections(int id)
        {
            var collections = collectionsRepository.GetCollections().FirstOrDefault(c => c.Id == id);

            if (collections == null) return NotFound();

            var itemCollection = itemRepository.GetItems().Where(i => i.Collections.Id == id);

            var viewModel = new CollectionsDetailVm();
            viewModel.Collections = collections;
            viewModel.Items = itemCollection;

            return View(viewModel);
        }
    }
}
