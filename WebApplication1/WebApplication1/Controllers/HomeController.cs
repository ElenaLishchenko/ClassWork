using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        UserContext db = new UserContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты User
            var users = db.Users;
            //db.Entry(users).Reference("UserType").Load();
            // передаем все объекты в свойство Users в ViewBag
            ViewBag.Users = users.ToList<User>();           
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.UserId = id;
            var user = db.Users.Find(id);
            ViewBag.UserName = user.Name;
            ViewBag.UserSurname = user.Surname;
            ViewBag.UserPatronymic = user.Patronymic;
            ViewBag.UserPhoneNumber = user.PhoneNumber;
            ViewBag.UserEmail = user.Email;
            return View();
        }

        [HttpPost]
        public string Edit(User user)
        {
            db.Users.Find(user.Id).Name = user.Name;
            db.Users.Find(user.Id).Surname = user.Surname;

            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Изменения сохранены!";            
        }

        [HttpGet]
        public ActionResult Add()
        {            
            return View();
        }

        [HttpPost]
        public string Add(User user)
        {
            db.Users.Add(user);
            
            // сохраняем в бд изменения
            db.SaveChanges();
            return "Запись добавлена";
        }

        [HttpGet]
        public string Delete(int id)
        {
            db.Users.Remove(db.Users.Find(id));

            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Запись удалена!";
        }

    }
}