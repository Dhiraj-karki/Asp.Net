using dhiraj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dhiraj.Controllers
{
    public class bit1Controller : Controller
    {
        // GET: bit1
        StudentEntities db = new StudentEntities();
        public ActionResult index1()
        {
            List<doctor> all_data = db.doctors.ToList();
            return View(all_data);
        }
        public ActionResult dhiraj1()
        {
            List<doctor> all_data = db.doctors.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult edit1(int id)
        {
            doctor doctor = db.doctors.Find(id);//find data using primary key
            return View(doctor);
        }
        public ActionResult savedata(doctor doctor)
        {
            db.doctors.Add(doctor);
            db.SaveChanges();
            return RedirectToAction("Index1");
        }
        public ActionResult Updatedata(doctor doctor)
        {
            db.Entry(doctor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index1");
        }
        public ActionResult deletedata(int d_id)
        {
            doctor data = db.doctors.Find(d_id);
            db.doctors.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index1");
        }
    }
}