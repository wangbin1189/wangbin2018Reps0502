using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Web;

namespace PowerKSI.Utils
{
    public static class SessionAdapter
    {
        public static void SetUserName(string userName)
        {
            HttpContext.Current.Session.Add("userName", userName);
        }

        public static string GetUserName()
        {
            return (string) (HttpContext.Current.Session["userName"] ?? null);
        }

        public static void SetUsername(string username)
        {
            HttpContext.Current.Session.Add("userName", username);
        }

        public static string GetUsername()
        {
            return (string)(HttpContext.Current.Session["username"] ?? null);
        }

        public static void SetAcademicYearId(int yearid)
        {
            HttpContext.Current.Session.Add("academicYearId", yearid);
        }

        public static int GetAcademicYearId()
        {
            return (int)HttpContext.Current.Session["academicYearId"];
        }

        public static void SetInstructorId(int instructorId)
        {
            HttpContext.Current.Session.Add("instructorId", instructorId);
        }

        public static int? GetInstructorId()
        {
            return HttpContext.Current.Session["instructorId"] != null ? (int)HttpContext.Current.Session["instructorId"] : (int?)null;
        }

        public static void SetStudentId(int studentId)
        {
            HttpContext.Current.Session.Add("studentId", studentId);
        }

        public static int? GetStudentId()
        {
            return HttpContext.Current.Session["studentId"] != null ? (int)HttpContext.Current.Session["studentId"] : (int?)null;
        }

        
        public static void SetAdminId(int adminId)
        {
            HttpContext.Current.Session.Add("adminId", adminId);
        }

        public static int? GetAdminId()
        {
            return HttpContext.Current.Session["adminId"] != null ? (int)HttpContext.Current.Session["adminId"] : (int?)null;
        }

        public static void Clear()
        {
            HttpContext.Current.Session.Contents.Clear();
        }
    }
}