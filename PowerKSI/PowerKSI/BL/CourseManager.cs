using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KSI.EntityClasses;
using PowerKSI.BL;

namespace PowerKSI.BL
{
    public class CourseManager
    {
        public static bool CreateCourse(string coursenumber, string title, string description, bool hasprerequisite,  string prerequisite1, string prerequisite2, string prerequisite3, out string error)
        {
            error = String.Empty;

            var Course = new CourseEntity()
            {
                CourseNumber= coursenumber,
                Title=title,
                Description=description,
                HasPrerequisite=hasprerequisite,
                Prerequisite1=prerequisite1,
                Prerequisite2=prerequisite2,
                Prerequisite3=prerequisite3
            };

            return Course.Save();
        }

        public static bool UpdateCourse(int courseid, string coursenumber, string title, string description, bool hasprerequisite,  string prerequisite1, string prerequisite2, string prerequisite3, out string error)
        {
            error = String.Empty;

            var Instructor = new CourseEntity(courseid)
            {
                Id = courseid,
                CourseNumber = coursenumber,
                Title = title,
                Description = description,
                HasPrerequisite = hasprerequisite,
                Prerequisite1 = prerequisite1,
                Prerequisite2 = prerequisite2,
                Prerequisite3 = prerequisite3
            };

            return Course.Save();
        }

        public static bool DeleteCourse(int courseId, out string error)
        {
            error = null;
            try
            {
                var toDelete = new CourseEntity(courseId);
                return toDelete.Delete();
            }
            catch (Exception ex)
            {
                error = "<h3>Oops...Something went wrong! Item can not be deleted!</h3> <b>Reason:</b>" + ex.Message;
                return false;
            }
        }
    }
}