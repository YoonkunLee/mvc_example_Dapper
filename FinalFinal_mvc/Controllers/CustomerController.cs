using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using FinalFinal_mvc.DataContext;
using FinalFinal_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalFinal_mvc.Controllers
{
    public class CustomerController : Controller
    {
        string Connection = DataConnection.DataConnectionID;

        [HttpGet]
        public IActionResult Index()
        {           
            using (var db = new SqlConnection(Connection))
            {
               // var list = db.Users.ToList();

                //var females = new List<User>();

                //for(int i=0; i<list.Count; i++)
                //{
                //    if(list[i].Gender =="F")
                //    {
                //        females.Add(list[i]);
                //    }
                //}

                //var femailUserNames = new List<string>();
                //foreach (var user in list)
                //{
                //    if (user.Gender == "F")
                //    {
                //        femailUserNames.Add(user.UserName);
                //    }
                //}
                //var females1 = list.Where(m => m.Gender.Equals("F")).Select(m => m.UserName).ToList();

                //var females2 = from user in list
                //              where user.Gender == "F"
                //              select user.UserName;

                //list.ForEach(m => m.Email = "");
                //list.ForEach(m => m.Email = string.Empty);
                //list.ForEach(m =>
                //{
                //    m.Email = "";
                //    m.Gender = "";
                //});

                List<User> UserList = new List<User>();
                UserList = db.Query<User>("Select * From Users").ToList();

                    return View(UserList);
            }
        }       
        
        public IActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enroll(User m)
        {
            if (ModelState.IsValid)
            {
                string sql = @"Insert into Users (UserName, Gender, Email, Date) VALUES(@UserName, @Gender, @Email, @Date);";

                using (var db = new SqlConnection(Connection))
                {
                    var myCommand = db.Execute(sql, new { UserName = m.UserName, Gender = m.Gender, Email = m.Email, Date = m.Date });

                    Console.WriteLine(myCommand);                      
                }
                return RedirectToAction("Success", "Customer", m);
            }
            return View(m);
        }

        public IActionResult Update(int? id)
        {
            User user = new User();

            using (var db = new SqlConnection(Connection))
            {
                //var user ="SELECT * FROM Users WHERE id = @id;";
                //var result = db.Query(user, new { id = Id });

                user = db.Query<User>("Select * From Users " +
                                    "WHERE id =" + id, new { id }).SingleOrDefault();                              
                return View(user);
            }
        }

        [HttpPost]
        public IActionResult Update(User m)
        {
            using (var db = new SqlConnection(Connection))
            {
                string updateQuery = "UPDATE Users SET UserName = @UserName, Gender = @Gender, Email = @Email, Date = @Date Where id = @id;";

                if (m == null)
                {
                    return RedirectToAction("Enroll");
                }
                if (ModelState.IsValid)
                {
                    var update = db.Execute(updateQuery, new { UserName = m.UserName, Gender = m.Gender, Email = m.Email, Date = m.Date, id = m.id });
                    Console.WriteLine(update);

                    return ReDirectToIndex();
                }
                return View(m);
            }
        }

       
        public JsonResult Delete(int id)
        {
            using (var db = new SqlConnection(Connection))
            {
                string myCommand = @"Delete From Users Where id = '" + id + "';";
                db.Execute(myCommand);
            }
            return Json(new { success = true });

        }

        public IActionResult ReDirectToIndex()
        {
            return RedirectToAction("Index", "Customer");
        }

        public IActionResult Success(User user)
        {
            return View(user);
        }
    }
}