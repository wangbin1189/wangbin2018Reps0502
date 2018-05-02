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
    public partial class Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlOffering_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void rg1_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rg1.DataSource = GetStudentCollection();
        }

        protected void rg1_ItemDataBound(object sender, GridItemEventArgs e)
        {
            
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            
        }

        public static StudentCollection GetStudentCollection()
        {
            var toReturn = new StudentCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            var sorter = new SD.LLBLGen.Pro.ORMSupportClasses.SortExpression { };
            toReturn.GetMulti(filter, 0, sorter, relations);
            return toReturn;
        }
    }
}