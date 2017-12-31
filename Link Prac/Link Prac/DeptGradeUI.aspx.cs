using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Link_Prac
{
    public partial class DeptGradeUI : System.Web.UI.Page
    {
        AjaxDataContextDataContext db=new AjaxDataContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeptsaveButton_Click(object sender, EventArgs e)
        {
            string name = DeptnameTextBox.Text;
            var isExist = db.tbl_Departments.FirstOrDefault(x => x.Name == name);
            if (isExist == null)
            {
               var dept=new tbl_Department();

                dept.Name = name;
                dept.Salary = Convert.ToDouble(salaryTextBox.Text);
                db.tbl_Departments.InsertOnSubmit(dept);
                db.SubmitChanges();
                deptMsgLabel.Text = "Save Succesfully";
            }
            else
            {
                deptMsgLabel.Text = "Save Failed";
            }
        }

        protected void GradeButton_Click(object sender, EventArgs e)
        {
            string name = gradenameTextBox.Text;
            var isExist = db.tbl_Grades.FirstOrDefault(x => x.GradeName == name);
            if (isExist == null)
            {
               var gards=new tbl_Grade();
                gards.GradeName = name;
                gards.Bonus = Convert.ToDouble(BonusTextBox.Text);
                db.tbl_Grades.InsertOnSubmit(gards);
                db.SubmitChanges();
                gradeMsgLabel.Text = "Save Successfully";
            }
            else
            {
                gradeMsgLabel.Text = "Save Failed";
            }
        }
    }
}