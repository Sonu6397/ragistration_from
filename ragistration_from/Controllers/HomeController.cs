using ragistration_from.dbo_connt;
using ragistration_from.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ragistration_from.Controllers
{
    public class HomeController : Controller
    {
        dummyEntities db = new dummyEntities();
        public ActionResult Index()
        {
            var res = db.Students.ToList();
            List<Stdmodel> obj = new List<Stdmodel>();
            foreach (var item in res)
            {
                obj.Add(new Stdmodel
                {
                    Id = item.Id,
                    Fname = item.Fname,
                    Lname = item.Lname,
                    Qalification = item.Qalification,
                    Gender = item.Gender,
                   
                });
            }
            return View(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        } 
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Student b)
        {
            db.Students.Add(b);
            db.SaveChanges();
            return RedirectToAction("index");

        }

        public ActionResult Delete(int id)
        {
            var Dt = db.Students.Where(x => x.Id == id).FirstOrDefault();
            db.Students.Remove(Dt);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Et = db.Students.Where(x => x.Id == id).FirstOrDefault();
            db.SaveChanges();
            return View(Et);
        }
        public ActionResult Edit(Student d)
        {
            db.Entry(d).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}