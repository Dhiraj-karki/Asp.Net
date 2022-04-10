using dhiraj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dhiraj.Controllers
{
    public class bit2Controller : Controller
    {
        // GET: bit2
        StudentEntities db = new StudentEntities();
        public ActionResult Index2()
        {
            List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            return View(all_data);
        }
        public ActionResult Salary()
        {
            List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            var empList = db.Table_1.ToList();
            // ViewBag.empsList=empList;
            ViewBag.employeeList = new SelectList(empList, "id", "name");
            return View(all_data);
        }
        
        public ActionResult Edit2(int id)
        {
            var empList = db.Table_1.ToList();
            // ViewBag.empsList=empList;
            ViewBag.employeeList = new SelectList(empList, "id", "name");
            employee_salary_details employee_Salary_Details = db.employee_salary_details.Find(id);//find data using primary key
            return View(employee_Salary_Details);
        }
        public ActionResult savedata(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        
        public ActionResult UpdateData(employee_salary_details employee_Salary_Details)
        {
            db.Entry(employee_Salary_Details).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult deletedata(int id)
        {
            employee_salary_details data = db.employee_salary_details.Find(id);
            db.employee_salary_details.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
    }
}