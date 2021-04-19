using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;

namespace pe1.Webshop.Web.Controllers
{
    public class PropertyController : Controller
    {

        private readonly PropertyRepository propertyRepository;
        private readonly ItemRepository itemRepository;

        public PropertyController()
        {
            propertyRepository = new PropertyRepository();
            itemRepository = new ItemRepository();
        }

       
            [Route("properties")]
            [Route("properties/index")]
            [Route("properties/all")]

            public IActionResult Index()
            {
                var viewModel = new PropertyIndexVm();
                viewModel.Properties = propertyRepository.GetProperties();

                return View(viewModel);
            }

        [Route("properties/{id}")]
        public IActionResult ShowProperty(int id)
        {
            var property = propertyRepository.GetProperties().FirstOrDefault(c => c.Id == id);

            if (property == null) return NotFound();

            var itemProperty = itemRepository.GetItems().Where(i => i.Property.Id == id);

            var viewModel = new PropertyDetailVm();
            viewModel.Property = property;
            viewModel.Items = itemProperty;

            return View(viewModel);
        }

    }
    }

