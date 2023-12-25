using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_CurdOperation.Models;

namespace MVC_CurdOperation.Controllers
{
    public class EmployeeHomeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: EmployeeHome
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid==true)
            {
                db.Employees.Add(emp);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "<script>alert('Data Inserted Successfully !!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertMessage"] = "<script>alert('Data Insertion Failed !!')</script>";
                }
            }
           
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Employees.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if(ModelState.IsValid==true)
            {
                db.Entry(emp).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert(' Successfully Edited!!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["UpdateMessage"] = "<script>alert(' Failed !!')</script>";
                }
            }
           
            return View();
        }

        public ActionResult Delete(int id)
        {
            var empid = db.Employees.Where(model => model.Id == id).FirstOrDefault();
            
            return View(empid);
        }
        [HttpPost]
        public ActionResult Delete(Employee emp)
        {
            
                db.Entry(emp).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["Deletemessage"] = "<script>alert('Data Deleted Successfully !!')</script>";
                    
                }
                else
                {
                    TempData["Deletemessage"] = "<script>alert('Try Again !!')</script>";
                }
            
            return RedirectToAction("Index");
            
        }
        public ActionResult Details(int id)
        {
            var rowid = db.Employees.Where(model => model.Id == id).FirstOrDefault();
            return View(rowid);
        }
        

    }
}