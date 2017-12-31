using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLamda.Models;

namespace MVCLamda.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            AjaxDBEntities db = new AjaxDBEntities();
            tbl_Employee emodel = db.tbl_Employee.SingleOrDefault(x => x.id == 1);
            EmployeeViewModel employee = new EmployeeViewModel();
            employee.Name = emodel.Name;
            employee.Gender = emodel.Gender;
            employee.DepartmentId = emodel.DepartmentId;
            employee.GradeId = emodel.GradeId;
            employee.Address = emodel.Address;
            return View(employee);
        }
        [HttpPost]
        public ActionResult Index(EmployeeViewModel Employee)
        {
            AjaxDBEntities db=new AjaxDBEntities();
            List<tbl_Employee> employees = db.tbl_Employee.ToList();
            ViewBag.data = new SelectList(employees, "id", "Name");
           
            if (Employee.id > 0)
            {
                tbl_Employee Employess = db.tbl_Employee.SingleOrDefault(x => x.id == Employee.id);
                Employess.Name = Employee.Name;
                Employess.Gender = Employee.Gender;
                Employess.DepartmentId = Employee.DepartmentId;
                Employess.GradeId = Employee.GradeId;
                Employess.Address = Employee.Address;
                db.SaveChanges();

            }
            else
            {
                tbl_Employee employee=new tbl_Employee();
                employee.Name = Employee.Name;
                employee.Gender = Employee.Gender;
                employee.DepartmentId = Employee.DepartmentId;
                employee.GradeId = Employee.GradeId;
                employee.Address = Employee.Address;
                db.tbl_Employee.Add(employee);
                db.SaveChanges();

            }
            return View(Employee);

        }
        public ActionResult WorkMultipleTble()
        {
            AjaxDBEntities db = new AjaxDBEntities();
            List<tbl_Employee> Employess = db.tbl_Employee.ToList();
            List<EmployeeViewModel> employeeView = Employess.Select(x =>new EmployeeViewModel
            {
                id = x.id,
                Name = x.Name,
                Gender = x.Gender,
                DepartmentId = x.DepartmentId,
                GradeId = x.GradeId,
                Address = x.Address,
                //DepartmentName = x.tbl_Department.Name

            }).ToList();
            return View(employeeView);
        }

        public ActionResult EmployeDetails(int em)
        {
            AjaxDBEntities db = new AjaxDBEntities();
            tbl_Employee employee = db.tbl_Employee.SingleOrDefault(x => x.id == em);
            EmployeeViewModel viewModel = new EmployeeViewModel();
            viewModel.Name = employee.Name;
            viewModel.Gender = employee.Gender;
            viewModel.Address = employee.Address;
            return View(viewModel);
        }

        public ActionResult ChaeckBox()
        {
            AjaxDBEntities db = new AjaxDBEntities();
            List<tbl_Employee> employees = db.tbl_Employee.ToList();
            ViewBag.datlist = new SelectList(employees, "id", "Name");
            return View();

        }

        public ActionResult saveData()
        {
            //AjaxDBEntities db=new AjaxDBEntities();
            //tbl_Employee tblem=new tbl_Employee();
            //tblem.Name = em.Name;
            //tblem.Address = em.Address;
            //tblem.DepartmentId = em.DepartmentId;
            //db.tbl_Employee.Add(tblem);
            //db.SaveChanges();
            //return RedirectToAction("ChaeckBox");
            return View();
        }
        [HttpPost]
        public ActionResult saveData(EmployeeViewModel em)
        {
            
                AjaxDBEntities db = new AjaxDBEntities();
                tbl_Employee tblem = new tbl_Employee();
                tblem.Name = em.Name;
                tblem.Address = em.Address;
                tblem.DepartmentId = em.DepartmentId;
                db.tbl_Employee.Add(tblem);
                db.SaveChanges();
       
            return View(em);
         }

        public JsonResult Delete(int EmployeeId)
        {
            AjaxDBEntities db=new AjaxDBEntities();
            tbl_Employee Employee = db.tbl_Employee.SingleOrDefault(x => x.id == EmployeeId);
            bool result = false;
            if (Employee != null)
            {
                db.SaveChanges();
                result = true;
            }

            return Json(result,JsonRequestBehavior.AllowGet);
        }

       
        public ActionResult ShowEmployee(int Employeeid)
        {
            AjaxDBEntities db=new AjaxDBEntities();
            List<EmployeeViewModel> viewModels = db.tbl_Employee.Where(x=>x.id==Employeeid).Select(x => new EmployeeViewModel
            {
                Name = x.Name,
                Gender = x.Gender,
                DepartmentId = x.DepartmentId,
                GradeId = x.GradeId,
                Address = x.Address
            }).ToList();
            ViewBag.emplist = viewModels;
            return PartialView("partial1");
            //tbl_Employee employee = db.tbl_Employee.SingleOrDefault(x => x.id == Employeeid);
            //
        }
        public ActionResult AddEditEmployee(int Employee)
        {
             
            AjaxDBEntities db=new AjaxDBEntities();
            EmployeeViewModel viewModel = new EmployeeViewModel();
             List<tbl_Employee> employees = db.tbl_Employee.ToList();
             ViewBag.data=new SelectList(employees,"id", "Name");
          
             if (Employee > 0)
             {
                 tbl_Employee employee = db.tbl_Employee.SingleOrDefault(x => x.id == Employee);
                 viewModel.id = employee.id;
                 viewModel.Name = employee.Name;
                 viewModel.Gender = employee.Gender;
                 viewModel.DepartmentId = employee.DepartmentId;
                 viewModel.GradeId = employee.GradeId;
                 viewModel.Address = employee.Address;
                 

             }
             return PartialView("Partial2", viewModel);

        }

        public ActionResult Register()
        {
             AjaxDBEntities db=new AjaxDBEntities();
            List<tbl_Department> Lists = db.tbl_Department.ToList();
            ViewBag.Datalist=new SelectList(Lists,"id","Name");
            return View();
        }
        [HttpPost]
        public ActionResult Register(EmployeeViewModel em)
        {

            AjaxDBEntities db = new AjaxDBEntities();
            List<tbl_Department> Lists = db.tbl_Department.ToList();
            ViewBag.Datalist = new SelectList(Lists, "id", "Name");
           tbl_Employee employee=new tbl_Employee();
            employee.Name = em.Name;
            employee.Gender = em.Gender;
            employee.DepartmentId = em.DepartmentId;
            employee.GradeId = em.GradeId;
            employee.Address = em.Address;
            db.tbl_Employee.Add(employee);
            db.SaveChanges();
            
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(EmployeeViewModel model)
        {
            
            AjaxDBEntities db = new AjaxDBEntities();
            tbl_Employee data = db.tbl_Employee.SingleOrDefault(x => x.Name ==model.Name && x.Address == model.Address);
            if (data != null)
            {
                Session["Name"] = model.Name;
                Session["Address"] = model.Address;
            }
            return View(model);
        }
        
    }
}