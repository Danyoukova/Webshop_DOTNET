using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Views.Shared.Components
{
    [ViewComponent(Name = "TopbarNavigation")]
    public class TopNavComponent: ViewComponent
    {
            public async Task<IViewComponentResult> InvokeAsync()
            {
                return View();
            }
        
    }
}
