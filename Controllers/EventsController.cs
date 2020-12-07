using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<Event> Events = new List<Event>();
        [HttpGet]
        public IActionResult Index()
        {
            /*Events.Add("Strange Loop");
            Events.Add("Grace Hopper");
            Events.Add("Code with Pride");*/
            ViewBag.events = Events;

            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/events/add")]
        public IActionResult NewEvent(string name, string description)
        {
            Events.Add(new Event(name, description));
            return Redirect("/Events");
        }
    }
}
