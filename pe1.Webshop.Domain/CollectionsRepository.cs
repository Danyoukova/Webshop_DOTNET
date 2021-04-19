using System;
using System.Collections.Generic;
using System.Text;

namespace pe1.Webshop.Domain
{
    public class CollectionsRepository
    {
        public IEnumerable<Collections> GetCollections()
        {
            return new List<Collections>
            {
                new Collections{ Id = 1, Name = "Accessoires" },
                new Collections{ Id = 2, Name = "Clothes" },
                new Collections{ Id = 3, Name = "Sneakers" }

            };
        }
    }
}
