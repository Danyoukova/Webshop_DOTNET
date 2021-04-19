using System;
using System.Collections.Generic;
using System.Text;

namespace pe1.Webshop.Domain
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescr { get; set; }

        public string Img { get; set; }
        public int Price { get; set; }
       
       
        public virtual Category Category { get; set; }
        public virtual Collections Collections { get; set; }
        public virtual Property Property { get; set; }
    }
}
