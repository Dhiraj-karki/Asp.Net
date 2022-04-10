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
            List<Table_1> all_data = db.Table_1.ToList();
            return View(all_data);
        }
        public ActionResult dhiraj1()
        {
            List<Table_1> all_data = db.Table_1.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult edit1(int id)
        {
            Table_1 table_1 = db.Table_1.Find(id);//find data using primary key
            return View(table_1);
        }
        public ActionResult savedata(Table_1 table_1)
        {
            db.Table_1.Add(table_1);
            db.SaveChanges();
            return RedirectToAction("Index1");
        }
        public ActionResult UpdateData(Table_1 table_1)
        {
            db.Entry(table_1).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index1");
        }
        /*public ActionResult deletedata(int d_id)
        {
            doctor data = db.doctors.Find(d_id);
            db.doctors.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index1");
        }*/
    }
}