﻿using pe1.Webshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class PropertyIndexVm
    {
        public IEnumerable<Property> Properties { get; set; }
    }
}
