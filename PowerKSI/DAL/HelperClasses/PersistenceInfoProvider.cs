///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace KSI.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass(11);
			InitAttendanceEntityMappings();
			InitAttendanceCodeEntityMappings();
			InitClassRegistrationEntityMappings();
			InitCourseEntityMappings();
			InitGradeBookEntityMappings();
			InitGradeItemEntityMappings();
			InitOfferingEntityMappings();
			InitOfferingScheduleEntityMappings();
			InitSemesterEntityMappings();
			InitStudentEntityMappings();
			InitUserEntityMappings();
		}

		/// <summary>Inits AttendanceEntity's mappings</summary>
		private void InitAttendanceEntityMappings()
		{
			this.AddElementMapping("AttendanceEntity", @"KSI", @"dbo", "Attendance", 7, 0);
			this.AddElementFieldMapping("AttendanceEntity", "AttendanceCodeId", "AttendanceCodeId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AttendanceEntity", "DateOfAttendance", "DateOfAttendance", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("AttendanceEntity", "Notes", "Notes", true, "VarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("AttendanceEntity", "OfferingId", "OfferingId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("AttendanceEntity", "StudentId", "StudentId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("AttendanceEntity", "SubmitDate", "SubmitDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("AttendanceEntity", "SubmittedBy", "SubmittedBy", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits AttendanceCodeEntity's mappings</summary>
		private void InitAttendanceCodeEntityMappings()
		{
			this.AddElementMapping("AttendanceCodeEntity", @"KSI", @"dbo", "AttendanceCode", 5, 0);
			this.AddElementFieldMapping("AttendanceCodeEntity", "Code", "Code", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("AttendanceCodeEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("AttendanceCodeEntity", "Name", "Name", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("AttendanceCodeEntity", "Status", "Status", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("AttendanceCodeEntity", "Type", "Type", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
		}

		/// <summary>Inits ClassRegistrationEntity's mappings</summary>
		private void InitClassRegistrationEntityMappings()
		{
			this.AddElementMapping("ClassRegistrationEntity", @"KSI", @"dbo", "ClassRegistration", 6, 0);
			this.AddElementFieldMapping("ClassRegistrationEntity", "FinalGrade", "FinalGrade", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ClassRegistrationEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ClassRegistrationEntity", "IsOnline", "IsOnline", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("ClassRegistrationEntity", "OfferingId", "OfferingId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ClassRegistrationEntity", "RegistrationDate", "RegistrationDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("ClassRegistrationEntity", "StudentId", "StudentId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits CourseEntity's mappings</summary>
		private void InitCourseEntityMappings()
		{
			this.AddElementMapping("CourseEntity", @"KSI", @"dbo", "Course", 9, 0);
			this.AddElementFieldMapping("CourseEntity", "CourseNumber", "CourseNumber", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CourseEntity", "Description", "Description", false, "VarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CourseEntity", "HasPrerequisite", "HasPrerequisite", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("CourseEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("CourseEntity", "Prerequisite1", "Prerequisite1", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CourseEntity", "Prerequisite2", "Prerequisite2", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("CourseEntity", "Prerequisite3", "Prerequisite3", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("CourseEntity", "Syllabus", "Syllabus", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 7);
			this.AddElementFieldMapping("CourseEntity", "Title", "Title", false, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits GradeBookEntity's mappings</summary>
		private void InitGradeBookEntityMappings()
		{
			this.AddElementMapping("GradeBookEntity", @"KSI", @"dbo", "GradeBook", 7, 0);
			this.AddElementFieldMapping("GradeBookEntity", "GradeItemId", "GradeItemId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("GradeBookEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("GradeBookEntity", "OfferingId", "OfferingId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("GradeBookEntity", "Score", "Score", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("GradeBookEntity", "StudentId", "StudentId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("GradeBookEntity", "SubmitDate", "SubmitDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("GradeBookEntity", "SubmittedBy", "SubmittedBy", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits GradeItemEntity's mappings</summary>
		private void InitGradeItemEntityMappings()
		{
			this.AddElementMapping("GradeItemEntity", @"KSI", @"dbo", "GradeItem", 5, 0);
			this.AddElementFieldMapping("GradeItemEntity", "FullScore", "FullScore", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("GradeItemEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("GradeItemEntity", "Name", "Name", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("GradeItemEntity", "Type", "Type", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("GradeItemEntity", "Weight", "Weight", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits OfferingEntity's mappings</summary>
		private void InitOfferingEntityMappings()
		{
			this.AddElementMapping("OfferingEntity", @"KSI", @"dbo", "Offering", 7, 0);
			this.AddElementFieldMapping("OfferingEntity", "Capacity", "Capacity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("OfferingEntity", "CourseId", "CourseId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("OfferingEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("OfferingEntity", "Instructor2Id", "Instructor2Id", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("OfferingEntity", "InstructorId", "InstructorId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("OfferingEntity", "RoomNumber", "RoomNumber", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("OfferingEntity", "SemesterId", "SemesterId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits OfferingScheduleEntity's mappings</summary>
		private void InitOfferingScheduleEntityMappings()
		{
			this.AddElementMapping("OfferingScheduleEntity", @"KSI", @"dbo", "OfferingSchedule", 5, 0);
			this.AddElementFieldMapping("OfferingScheduleEntity", "EndTime", "EndTime", false, "Time", 0, 0, 0, false, "", null, typeof(System.TimeSpan), 0);
			this.AddElementFieldMapping("OfferingScheduleEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("OfferingScheduleEntity", "OfferingId", "OfferingId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("OfferingScheduleEntity", "StartTime", "StartTime", false, "Time", 0, 0, 0, false, "", null, typeof(System.TimeSpan), 3);
			this.AddElementFieldMapping("OfferingScheduleEntity", "Weekday", "Weekday", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
		}

		/// <summary>Inits SemesterEntity's mappings</summary>
		private void InitSemesterEntityMappings()
		{
			this.AddElementMapping("SemesterEntity", @"KSI", @"dbo", "Semester", 4, 0);
			this.AddElementFieldMapping("SemesterEntity", "EndDate", "EndDate", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SemesterEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SemesterEntity", "Name", "Name", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SemesterEntity", "StartDate", "StartDate", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
		}

		/// <summary>Inits StudentEntity's mappings</summary>
		private void InitStudentEntityMappings()
		{
			this.AddElementMapping("StudentEntity", @"KSI", @"dbo", "Student", 7, 0);
			this.AddElementFieldMapping("StudentEntity", "Email", "Email", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("StudentEntity", "FirstName", "FirstName", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("StudentEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("StudentEntity", "IsOnline", "IsOnline", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3);
			this.AddElementFieldMapping("StudentEntity", "LastName", "LastName", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("StudentEntity", "Status", "Status", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("StudentEntity", "StudentId", "StudentId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"KSI", @"dbo", "User", 11, 0);
			this.AddElementFieldMapping("UserEntity", "Email", "Email", false, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("UserEntity", "FirstName", "FirstName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UserEntity", "FullName", "FullName", false, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("UserEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("UserEntity", "IsAdmin", "IsAdmin", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4);
			this.AddElementFieldMapping("UserEntity", "IsInstructor", "IsInstructor", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5);
			this.AddElementFieldMapping("UserEntity", "LastLoginDate", "LastLoginDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("UserEntity", "LastName", "LastName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("UserEntity", "RefId", "RefId", false, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("UserEntity", "Username", "Username", false, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 10);
		}

	}
}
