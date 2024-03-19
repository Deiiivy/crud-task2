using Microsoft.AspNetCore.Mvc;
using task_crud2.Models;
using System.Linq;

namespace task_crud2.Controllers
{
    public class TaskController1 : Controller
    {

        private readonly Task2Context _context;

        public TaskController1(Task2Context context) {  _context = context; }
        public IActionResult Index()
        {
            var task = _context.Tareas.ToList();
            return View(task);
        }

        
    }
}
