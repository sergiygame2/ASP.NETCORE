using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagesCRUD.Models;
using PagesCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace PagesCRUD.ViewComponents
{
    public class RandLinks : ViewComponent
    {
        private ApplicationDbContext db;

        public RandLinks(ApplicationDbContext context)
        {
            db = context;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Page>> GetItemsAsync()
        {
            return db.Page.OrderBy(link => Guid.NewGuid()).Take(3).ToListAsync();
        }
    }
}
