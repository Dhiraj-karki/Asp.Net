
using dhiraj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dhiraj.Controllers
{
    public class BitController : Controller
    {
        StudentEntities db = new StudentEntities();
        // GET: Bit
        public ActionResult Index()
        {
            List<Std> all_data = db.Stds.ToList();
            return View(all_data);
        }
        public ActionResult dhiraj()
        {
            List<Std> all_data = db.Stds.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Std std = db.Stds.Find(id);//find data using primary key
            return View(std);
        }
        public ActionResult savedata(Std employee)
        {
            db.Stds.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult updatedata(Std employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
    
   