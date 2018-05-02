using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KSI.CollectionClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Telerik.Web.UI;
using Telerik.Web.UI.Calendar;
using SortExpression = SD.LLBLGen.Pro.ORMSupportClasses.SortExpression;

namespace PowerKSI
{
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rg1_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            rg1.DataSource = GetStudentCollection();
        }

        protected void rg1_ItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item.ItemType == GridItemType.Item || e.Item.ItemType == GridItemType.AlternatingItem)
            {
                var item = (GridDataItem)e.Item;
                var ddlAttendanceCode = item.FindControl("ddlAttendanceCode") as DropDownList;
                this.BindAttendanceCodeDropdown(ddlAttendanceCode);
            }
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

        private void BindAttendanceCodeDropdown(DropDownList ddlAttendanceCode)
        {
            AttendanceCodeCollection toBind = GetAttendanceCodeCollection();
            ddlAttendanceCode.DataTextField = AttendanceCodeFields.Name.Name;
            ddlAttendanceCode.DataValueField = AttendanceCodeFields.Id.Name;
            ddlAttendanceCode.DataSource = toBind;
            ddlAttendanceCode.DataBind();
        }

        public static AttendanceCodeCollection GetAttendanceCodeCollection()
        {
            var toReturn = new AttendanceCodeCollection();
            IPredicateExpression filter = new PredicateExpression();
            IRelationCollection relations = new RelationCollection();

            toReturn.GetMulti(filter, 0, null, relations);
            return toReturn;
        }

        protected void rdpDate_textChanged(object sender, SelectedDateChangedEventArgs e)
        {
            
        }

        protected void ddlOffering_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnSetAll_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            
        }

        protected void lbtnCancel_OnClick(object sender, EventArgs e)
        {
            
        }
    }
}