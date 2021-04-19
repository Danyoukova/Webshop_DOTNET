using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;

namespace pe1.Webshop.Web.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly CategoryRepository categoryRepository;
        private readonly ItemRepository itemRepository;

        public CategoriesController()
        {
            categoryRepository = new CategoryRepository();
            itemRepository = new ItemRepository();

        }

        [Route("categories")]
        [Route("categories/index")]
        [Route("categories/all")]

        public IActionResult Index()
        {
            var viewModel = new CategoriesIndexVm();
            viewModel.Categories = categoryRepository.GetCategories();

            return View(viewModel);
        }



        [Route("categories/{id}")]
        public IActionResult ShowCategory(int id)
        {
            var category = categoryRepository.GetCategories().FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound();

            var itemCategory = itemRepository.GetItems().Where(i => i.Category.Id == id);

            var viewModel = new CategoriesDetailVm();
            viewModel.Category = category;
            viewModel.Items = itemCategory;

            return View(viewModel);
        }
    }
}
