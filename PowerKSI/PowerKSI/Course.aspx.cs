using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KSI.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using KSI.EntityClasses;
using PowerKSI.BL;

using Telerik.Web.UI;

namespace PowerKSI
{
    public partial class Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rptSyllabus_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }

        protected void lnkSyllabusDelete_OnClick(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string error = String.Empty;
            int courseid;
            string courseNumber = tbxCourseNumber.Text;
            string Title = tbxCourseTitle.Text;
            string Description = tbxDescription.Text;
            bool hasPrerequisite = cbxHasPrerequisite.Checked;
            string Prerequisite1;


            bool success = this.ViewState["courseId"] != null ?
                CourseManager.UpdateCourse(courseid, courseNumber, Title, Description, hasPrerequisite,  Prerequisite1, Prerequisite2, Prerequisite3, out error):
                CourseManager.CreateCourse(courseNumber, Title, Description, hasPrerequisite, Prerequisite1, Prerequisite2, Prerequisite3,, out error);
            if (success)
            {
                divForm.Visible = false;
                rgCourses.Rebind();
            }
            else
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Could not create course";
            }
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = false; 
        }

        protected void rgCourses_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            
        }

        protected void rgCourses_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rgCourses.DataSource = GetCourseCollection();
        }

        protected void lbtnAddNew_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = true;
            lbltitle.Text = "Add New Course";
            tbxCourseNumber.Text = string.Empty;
            tbxCourseTitle.Text = string.Empty;
            tbxDescription.Text = string.Empty;
            cbxHasPrerequisite.Checked = false;

        }

        protected void cbxHasPrerequisite_OnCheckedChanged(object sender, EventArgs e)
        {
            divPrerequisite1.Visible = divPrerequisite2.Visible = divPrerequisite3.Visible = cbxHasPrerequisite.Checked;
        }

        public static CourseCollection GetCourseCollection()
        {
            var toReturn = new CourseCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            toReturn.GetMulti(filter, 0, null, relations);
            return toReturn;
        }
    }
}