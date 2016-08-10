using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace PagesCRUD.Models
{
    public class PageRepository : IPageRepository
    {
        
        private static ConcurrentDictionary<string, Page> _todos =
              new ConcurrentDictionary<string, Page>();

        public PageRepository()
        {
            Add(new Page { UrlName = "Item1", Title = "Title", Description = "IREPOD", Content = "Some" });
        }

        public IEnumerable<Page> GetAll()
        {
            return _todos.Values;
        }

        public void Add(Page item)
        {
            item.UrlName = Guid.NewGuid().ToString();
            _todos[item.UrlName] = item;
        }

        public Page Find(string key)
        {
            Page item;
            _todos.TryGetValue(key, out item);
            return item;
        }

        public Page Remove(string key)
        {
            Page item;
            _todos.TryRemove(key, out item);
            return item;
        }

        public void Update(Page item)
        {
            _todos[item.UrlName] = item;
        }


    }
}
