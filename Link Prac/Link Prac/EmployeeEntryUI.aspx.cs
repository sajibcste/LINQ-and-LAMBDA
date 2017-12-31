using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Link_Prac
{
    public partial class EmployeeEntryUI : System.Web.UI.Page
    {
        AjaxDataContextDataContext db=new AjaxDataContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDepartmentDropDown();
                LoadGradeDropdown();
            }
        }

        private void LoadGradeDropdown()
        {
            var grads = from d in db.tbl_Grades
                select new
                {
                    d.Id,
                    d.GradeName
                };
            gradeDropDownList.DataSource = grads;
            gradeDropDownList.DataValueField = "Id";
            gradeDropDownList.DataTextField = "GradeName";
            gradeDropDownList.DataBind();
        }


        private void LoadDepartmentDropDown()
        {
            var depts = from d in db.tbl_Departments
                select new
                {
                    d.Id,
                    d.Name
                };

            DeptDropDownList.DataSource = depts;
            DeptDropDownList.DataValueField = "Id";
            DeptDropDownList.DataTextField = "Name";
            DeptDropDownList.DataBind();
        }

        protected void EmployeesaveButton_Click(object sender, EventArgs e)
        {
            string name = employeeNameTextBox.Text;
            var isExist = db.tbl_Employees.FirstOrDefault(x => x.Name == name);
            if (isExist == null)
            {
                var emloys=new tbl_Employee();
                emloys.Name = name;
                emloys.Gender = DropDownList1.SelectedValue;
                emloys.DepartmentId = Convert.ToInt32(DeptDropDownList.SelectedValue);
                emloys.GradeId = Convert.ToInt32(gradeDropDownList.SelectedValue);
                emloys.Address = addressTextBox.Value;
                db.tbl_Employees.InsertOnSubmit(emloys);
                db.SubmitChanges();
                msgLabel.Text = "Save Successfully";

            }
            else
            {
                msgLabel.Text = "Save Failed";
            }
        }
    }
}