using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        [HttpGet]
        [Route("EventCategory/Index)"]
        public IActionResult Index()
        {
            List<EventCategory> categories = context.Category.ToList();
            return View(categories);
        }
    }
}
