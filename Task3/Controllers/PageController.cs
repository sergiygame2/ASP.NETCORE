using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PagesCRUD.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PagesCRUD.Controllers
{
    [Route("api/[controller]")]
    public class PageController : Controller
    {
        public PageController(IPageRepository pageItems)
        {
            TodoItems = pageItems;
        }
        public IPageRepository TodoItems { get; set; }

        public IEnumerable<Page> GetAll()
        {
            return TodoItems.GetAll();
        }
        [HttpGet("{UrlName}", Name = "GetTodo")]
        public IActionResult GetByUrl(string UrlName)
        {
            var item = TodoItems.Find(UrlName);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Page item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            TodoItems.Add(item);
            return CreatedAtRoute("GetTodo", new { UrlName = item.UrlName }, item);
        }

        [HttpPatch("{UrlName}")]
        public IActionResult Update([FromBody] Page item, string UrlName)
        {
            if (item == null)
            {
                return BadRequest();
            }

            var todo = TodoItems.Find(UrlName);
            if (todo == null)
            {
                return NotFound();
            }

            item.UrlName = todo.UrlName;

            TodoItems.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{UrlName}")]
        public IActionResult Delete(string UrlName)
        {
            var todo = TodoItems.Find(UrlName);
            if (todo == null)
            {
                return NotFound();
            }

            TodoItems.Remove(UrlName);
            return new NoContentResult();
        }

    }
}
