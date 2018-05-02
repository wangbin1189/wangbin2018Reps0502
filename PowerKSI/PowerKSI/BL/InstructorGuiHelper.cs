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
    public class InstructorGuiHelper
    {
        public static UserEntity GetInstructor(int Id)
        {
            var toReturn = new UserEntity(Id);
            return toReturn.IsNew ? null : toReturn;
        }
    }
}