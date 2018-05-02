using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KSI.DaoClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PowerKSI.BL
{
    public class UserGuiHelper
    {
        public static DataTable GetUserUsingUserNamePasswordAsDataTable(string userName, string password)
        {
            var fields = new ResultsetFields(4);
            fields.DefineField(UserFields.Id, 0);
            fields.DefineField(UserFields.FullName, 1);
            fields.DefineField(UserFields.IsAdmin, 2);
            fields.DefineField(UserFields.IsInstructor, 3);

            var filter = new PredicateExpression
            {
                (UserFields.Username == userName | UserFields.Email == userName),
                UserFields.Password == password
            };

            var relations = new RelationCollection()
            {
            };

            var toReturn = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, toReturn, 0, null, filter, relations, true, null, null, 0, 0);
            return toReturn;
        }
    }
}