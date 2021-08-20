using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TodoListController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get: Todo
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _db.TodoModel.ToListAsync());
        }
        //Get-create
        public IActionResult CreateTodo()
        {
            return View();
        }

        [HttpPost]
        //là để ngăn chặn các cuộc tấn công giả mạo yêu cầu trên nhiều trang web.
        [ValidateAntiForgeryToken]
        public IActionResult CreateTodo(TodoModel todoModel)
        {
            if (ModelState.IsValid)
            {
                _db.TodoModel.Add(todoModel);
                _db.SaveChanges();//luu du lieu vao databases
                return RedirectToAction("Index");
            }
            else
            {
                return View(todoModel);
            }
        }
        //edit
        public IActionResult EditTodo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var todo = _db.TodoModel.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        [HttpPost,ActionName("EditTodo")]
        [ValidateAntiForgeryToken]
        public IActionResult EditTodo(TodoModel todoModel)
        {
            if (ModelState.IsValid)
            {
                _db.TodoModel.Update(todoModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todoModel);
        }

        //[httpDelete]
        public IActionResult Delete(int id)
        {
            var deteleTodo = _db.TodoModel.Find(id);

            if (deteleTodo == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.TodoModel.Remove(deteleTodo);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deteleTodo);
        }


    }
}
