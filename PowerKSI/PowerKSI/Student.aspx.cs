using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using KSI.CollectionClasses;
using PowerKSI.BL;
using Telerik.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SortExpression = SD.LLBLGen.Pro.ORMSupportClasses.SortExpression;

namespace PowerKSI
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string error = String.Empty;
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            int studentId = int.Parse(tbxStudentId.Text);
            string email = tbxEmail.Text;
            string status = ddlStatus.SelectedValue;
            bool isOnline = cbxIsOnline.Checked;

            bool success = this.ViewState["studentId"] != null ?
                StudentManager.UpdateStudent( (int)this.ViewState["studentId"], studentId, firstName, lastName, email, status, isOnline, out error) :
                StudentManager.CreateStudent(studentId, firstName, lastName, email, status, isOnline, out error);
            if (success)
            {
                divForm.Visible = false;
                rgStudent.Rebind();
            }
            else
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Could not create student";
            }
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = false;
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxEmail.Text = string.Empty;
        }

        protected void lbtnAddNew_OnClick(object sender, EventArgs e)
        {
            lblTitle.Text = "Add new Student";
            divForm.Visible = true;
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxEmail.Text = string.Empty;
        }

        protected void rgStudent_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            string error;
            var studentId = (int)e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["Id"];
            bool success = StudentManager.DeleteStudent(studentId, out error);
            if (success)
            {
                rgStudent.Rebind();
            }
            else
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Could not delete student";
            }
        }

        protected void rgStudent_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rgStudent.DataSource = GetStudentCollection();
        }

        public static StudentCollection GetStudentCollection()
        {
            var toReturn = new StudentCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();
          
            var sorter = new SortExpression { };
            toReturn.GetMulti(filter, 0, sorter, relations);
            return toReturn;
        }

        protected void rgStudent_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            divForm.Visible = true;
            int studentId = (int)this.rgStudent.SelectedValues["Id"];
            this.ViewState["studentId"] = studentId;
            var student = StudentGuiHelper.GetStudent(studentId);

            tbxFirstName.Text = student.FirstName;
            tbxLastName.Text = student.LastName;
            tbxStudentId.Text = student.StudentId.ToString();
            tbxEmail.Text = student.Email;
            ddlStatus.SelectedValue = student.Status;
            cbxIsOnline.Checked = student.IsOnline;
        }
    }
}