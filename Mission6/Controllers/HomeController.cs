using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {

        private TaskDataContext TaskContext {get; set;}
        public HomeController(TaskDataContext task_data)
        {
            TaskContext = task_data
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            ViewBag.Tasks = TaskContext.Category.ToList()
            return View();
        }

        [HttpPost]
        public IActionResult Tasks(Tasks task)
        {
            ViewBag.Tasks = TaskContext.Category.ToList()
            TaskContext.Add(task);
            TaskContext.SaveChanges();
            return View("TaskList");

        }

        public IActionResult TaskList()
        {
            ViewBag.Tasks = TaskContext.Category.ToList()

            var tasks = TaskContext.Tasks
                .Include(x => x.Category)
                .Where(x => x.Completed == False)
                .ToList();

            return View(tasks);
                
        }

        // EDIT 
        [HttpGet]
        public IActionResult Edit(int taskid) // change to whatever edit file david named
        {
            ViewBag.Tasks = TaskContext.Category.ToList()
            var task = TaskContext.Tasks.Single( x => x.TaskID == taskid);

            return view("TaskList", task);
        }

        [HttpPost]
        public IActionResult Edit(Tasks task) // change to whatever edit file david named
        {
            TaskContext.Update(task);
            TaskContext.SaveChanges();
            return RedirectToAction("TaskList");

        }
        
        [HttpPost]
        public IActionResult Delete(Tasks task)
        {
            TaskContext.Tasks.Remove(task);
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
