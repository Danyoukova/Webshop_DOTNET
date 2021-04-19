using System;
using System.Collections.Generic;
using System.Text;

namespace pe1.Webshop.Domain
{
    public class PropertyRepository
    {
        public IEnumerable<Property> GetProperties()
        {
            return new List<Property>
            {
                new Property{ Id = 1, Name = "NewIn" },
                new Property{ Id = 2, Name = "Outlet" },
                new Property{ Id = 3, Name = "Popular" },
                new Property{ Id = 4, Name = "Sport" },
                new Property{ Id = 5, Name = "Casual" }

            };
        }
    }
}
