﻿using pe1.Webshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class CollectionsDetailVm
    {
        public Collections Collections { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
