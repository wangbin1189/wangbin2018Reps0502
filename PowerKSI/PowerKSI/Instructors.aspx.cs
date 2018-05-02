using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KSI.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Telerik.Web.UI;
using PowerKSI.BL;
using SortExpression = Telerik.Web.UI.SortExpression;

namespace PowerKSI
{
    public partial class Instructors : System.Web.UI.Page
    {
        private object cbxIsOnline;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string error = String.Empty;
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string email = tbxEmail.Text;
            string username = tbxUsername.Text;
            bool isadmin = cbxIsAdmin.Checked;
            bool isinstructor = cbxIsInstructor.Checked;
            string fullname = firstName + " " + lastName;
            string Password = "123";
            string refled = "222";




            bool success = this.ViewState["Id"] != null ?
                InstructorManager.UpdateInstructor((int)this.ViewState["Id"], firstName, lastName, username, email, isadmin, isinstructor, Password, refled, out error) :
                InstructorManager.CreateInstructor(firstName, lastName, email, username, isadmin, isinstructor, Password, refled, out error);
            if (success)
            {
                divForm.Visible = false;
                rgInstructors.Rebind();
            }
            else
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Could not create instructor";
            }
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = false;
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxUsername.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            cbxIsAdmin.Checked = false;
            
        }

        protected void lbtnAddNew_OnClick(object sender, EventArgs e)
        {
            lblTitle.Text = "Add new Instructor";
            divForm.Visible = true;
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxUsername.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            cbxIsAdmin.Checked = false;
        }

        protected void rgInstructors_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rgInstructors.DataSource = GetUserCollection();
        }

        protected void rgInstructors_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            string error;
            var Id = (int)e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["Id"];
            bool success = InstructorManager.DeleteInstructor(Id, out error);
            if (success)
            {
                rgInstructors.Rebind();
            }
            else
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Could not delete instructor";
            }
        }

        public static UserCollection GetUserCollection()
        {
            var toReturn = new UserCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            toReturn.GetMulti(filter, 0, null, relations);
            return toReturn;
        }
        protected void rgInstructor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            divForm.Visible = true;
            int id = (int)this.rgInstructors.SelectedValues["Id"];
            this.ViewState["Id"] = id;
            var instructor = InstructorGuiHelper.GetInstructor(id);

            tbxFirstName.Text = instructor.FirstName;
            tbxLastName.Text = instructor.LastName;

            tbxEmail.Text = instructor.Email;
        }
            
    }
}