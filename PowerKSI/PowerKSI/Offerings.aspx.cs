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
    public partial class Offerings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = false;
            ddlSemester.SelectedValue = null;
            ddlCourse.SelectedValue = null;
            ddlPrimaryInstructor.SelectedValue = null;
            ddlSecondaryInstructor.SelectedValue = null;
        }

        protected void rgOfferings_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rgOfferings.DataSource = GetOfferingCollection();
        }

        protected void rgOfferings_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            
        }

        protected void lbtnAddNew_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = true;
            ddlSemester.SelectedValue = null;
            ddlCourse.SelectedValue = null;
            ddlPrimaryInstructor.SelectedValue = null;
            ddlSecondaryInstructor.SelectedValue = null;
        }

        public static OfferingCollection GetOfferingCollection()
        {
            var toReturn = new OfferingCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            toReturn.GetMulti(filter, 0, null, relations);
            return toReturn;
        }
    }
}