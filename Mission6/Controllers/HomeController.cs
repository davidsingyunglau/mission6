using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {

        private TaskDataContext TaskContext {get; set;}
        public HomeController(TaskDataContext task_data)
        {
            TaskContext = task_data;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            ViewBag.Tasks = TaskContext.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Tasks(Tasks ethan)
        {
            ViewBag.Tasks = TaskContext.Category.ToList();
            TaskContext.Add(ethan);
            TaskContext.SaveChanges();
            return RedirectToAction("TaskList");

        }

        public IActionResult TaskList()
        {
            ViewBag.Tasks = TaskContext.Category.ToList();

            var josh = TaskContext.Tasks
                .Include(x => x.Category)
                .Where(x => x.Completed == false)
                .ToList();

            return View(josh);
                
        }

        // EDIT 
        [HttpGet]
        public IActionResult Edit(int taskid) // change to whatever edit file david named
        {
            ViewBag.Tasks = TaskContext.Category.ToList();
            var ethan = TaskContext.Tasks.Single( x => x.TaskID == taskid);

            return View("Tasks", ethan);
        }

        [HttpPost]
        public IActionResult Edit(Tasks ethan) // change to whatever edit file david named
        {
            TaskContext.Update(ethan);
            TaskContext.SaveChanges();
            return RedirectToAction("TaskList");

        }
        
        [HttpPost]
        public IActionResult Delete(Tasks ethan)
        {
            TaskContext.Tasks.Remove(ethan);
            TaskContext.SaveChanges();
            return RedirectToAction("TaskList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
