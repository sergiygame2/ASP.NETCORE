using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesCRUD.Models
{
    public interface IPageRepository
    {
        void Add(Page item);
        IEnumerable<Page> GetAll();
        Page Find(string key);
        Page Remove(string key);
        void Update(Page item);
    }
}
