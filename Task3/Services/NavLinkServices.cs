using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesCRUD.Services
{
    public class NavLinkServices
    {
        public List<string> ListItems()
        {
            return new List<string>() { "Page1", "Page2", "Page3", "Page4" };
        }
    }
}

