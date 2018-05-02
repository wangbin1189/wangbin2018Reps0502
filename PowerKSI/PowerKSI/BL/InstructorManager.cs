using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KSI.EntityClasses;

namespace PowerKSI.BL
{
    public class InstructorManager
    {
        public static bool CreateInstructor(string firstname, string lastname, string email, string username, bool isadmin, bool isinstructor, string password, string refled, out string error)
        {
            error = String.Empty;

            var Instructor = new UserEntity()
            {
                FirstName=firstname,
                LastName=lastname,
                Email=email,
                Username=username,
                IsAdmin=isadmin,
                IsInstructor=isinstructor,
                FullName=firstname+" "+lastname,
                Password= "123",
                RefId=refled

            };

            return Instructor.Save();
        }

        public static bool UpdateInstructor(int id, string firstname, string lastname, string email, string username, bool isadmin, bool isinstructor, string password, string refled, out string error)
        {
            error = String.Empty;

            var Instructor = new UserEntity(id)
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Username = username,
                IsAdmin = isadmin,
                IsInstructor = isinstructor,
                FullName = firstname + " " + lastname,
                Password = "123",
                RefId=refled
            };

            return Instructor.Save();
        }

        public static bool DeleteInstructor(int id, out string error)
        {
            error = null;
            try
            {
                var toDelete = new UserEntity(id);
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