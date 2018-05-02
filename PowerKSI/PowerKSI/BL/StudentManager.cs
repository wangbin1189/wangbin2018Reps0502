using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KSI.EntityClasses;

namespace PowerKSI.BL
{
    public class StudentManager
    {
        public static bool CreateStudent(int studentId, string firstName, string lastName, string email, string status, bool isOnline, out string error)
        {
            error = String.Empty;

            var student = new StudentEntity()
            {
                StudentId = studentId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Status = status,
                IsOnline = isOnline
            };

            return student.Save();
        }

        public static bool UpdateStudent(int id, int studentId, string firstName, string lastName, string email, string status, bool isOnline, out string error)
        {
            error = String.Empty;

            var student = new StudentEntity(id)
            {
                StudentId = studentId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Status = status,
                IsOnline = isOnline
            };

            return student.Save();
        }

        public static bool DeleteStudent(int studentId, out string error)
        {
            error = null;
            try
            {
                var toDelete = new StudentEntity(studentId);
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