using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KSI.DaoClasses;
using KSI.EntityClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PowerKSI.BL
{
    public class StudentGuiHelper
    {
        public static StudentEntity GetStudent(int studentId)
        {
            var toReturn = new StudentEntity(studentId);
            return toReturn.IsNew ? null : toReturn;
        }
    }
}