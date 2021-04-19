using System;
using System.Collections.Generic;
using System.Text;

namespace pe1.Webshop.Domain
{
    public class CategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category{ Id = 1, Name = "Men" },
                new Category{ Id = 2, Name = "Women" },
                new Category{ Id = 3, Name = "Kids" }

            };
        }
    }
}
