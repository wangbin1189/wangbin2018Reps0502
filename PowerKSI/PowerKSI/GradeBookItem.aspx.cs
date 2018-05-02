using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KSI.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Telerik.Web.UI;
using SortExpression = Telerik.Web.UI.SortExpression;

namespace PowerKSI
{
    public partial class GradeBookItem : System.Web.UI.Page
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
        }

        protected void lbtnAddNew_OnClick(object sender, EventArgs e)
        {
            divForm.Visible = true;
        }

        protected void rgGradeItem_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rgGradeItem.DataSource = GetGradeItemCollection();
        }

        protected void rgGradeItem_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            
        }

        public static GradeItemCollection GetGradeItemCollection()
        {
            var toReturn = new GradeItemCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            toReturn.GetMulti(filter, 0, null, relations);
            return toReturn;
        }
    }
}