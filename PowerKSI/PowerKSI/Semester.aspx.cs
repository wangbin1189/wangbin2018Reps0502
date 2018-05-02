using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KSI.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Telerik.Web.UI;

namespace PowerKSI
{
    public partial class Semester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            
        }

        protected void rgSemesters_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            
        }

        protected void rgSemesters_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rgSemesters.DataSource = GetSemesterCollection();
        }

        protected void lbtnAddNew_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = true;
            lbltitle.Text = "Add a new Semester";
            tbxSemesterName.Text = string.Empty;
            rdpStartDate.SelectedDate = null;
            rdpEndDate.SelectedDate = null;
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = false;
            lbltitle.Text = "Edit Semester";
            tbxSemesterName.Text = string.Empty;
            rdpStartDate.SelectedDate = null;
            rdpEndDate.SelectedDate = null;
        }

        public static SemesterCollection GetSemesterCollection()
        {
            var toReturn = new SemesterCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            toReturn.GetMulti(filter, 0, null, relations);
            return toReturn;
        }
    }
}