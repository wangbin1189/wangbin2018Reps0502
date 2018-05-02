using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KSI.DaoClasses;
using KSI.EntityClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using PowerKSI.BL;

namespace PowerKSI.BL
{
    public class CourseGuiHelper
    {
        public static CourseEntity GetCourse(int courseId)
        {
            var toReturn = new CourseEntity(courseId);
            return toReturn.IsNew ? null : toReturn;
        }
    }
}