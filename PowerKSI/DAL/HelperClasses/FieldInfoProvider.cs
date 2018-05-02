///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace KSI.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (11 + 0));
			InitAttendanceEntityInfos();
			InitAttendanceCodeEntityInfos();
			InitClassRegistrationEntityInfos();
			InitCourseEntityInfos();
			InitGradeBookEntityInfos();
			InitGradeItemEntityInfos();
			InitOfferingEntityInfos();
			InitOfferingScheduleEntityInfos();
			InitSemesterEntityInfos();
			InitStudentEntityInfos();
			InitUserEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AttendanceEntity's FieldInfo objects</summary>
		private void InitAttendanceEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AttendanceFieldIndex), "AttendanceEntity");
			this.AddElementFieldInfo("AttendanceEntity", "AttendanceCodeId", typeof(System.Int32), false, false, false, false,  (int)AttendanceFieldIndex.AttendanceCodeId, 0, 0, 10);
			this.AddElementFieldInfo("AttendanceEntity", "DateOfAttendance", typeof(System.DateTime), true, false, false, false,  (int)AttendanceFieldIndex.DateOfAttendance, 0, 0, 0);
			this.AddElementFieldInfo("AttendanceEntity", "Notes", typeof(System.String), false, false, false, true,  (int)AttendanceFieldIndex.Notes, 2147483647, 0, 0);
			this.AddElementFieldInfo("AttendanceEntity", "OfferingId", typeof(System.Int32), true, false, false, false,  (int)AttendanceFieldIndex.OfferingId, 0, 0, 10);
			this.AddElementFieldInfo("AttendanceEntity", "StudentId", typeof(System.Int32), true, false, false, false,  (int)AttendanceFieldIndex.StudentId, 0, 0, 10);
			this.AddElementFieldInfo("AttendanceEntity", "SubmitDate", typeof(System.DateTime), false, false, false, false,  (int)AttendanceFieldIndex.SubmitDate, 0, 0, 0);
			this.AddElementFieldInfo("AttendanceEntity", "SubmittedBy", typeof(System.Int32), false, false, false, false,  (int)AttendanceFieldIndex.SubmittedBy, 0, 0, 10);
		}
		/// <summary>Inits AttendanceCodeEntity's FieldInfo objects</summary>
		private void InitAttendanceCodeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AttendanceCodeFieldIndex), "AttendanceCodeEntity");
			this.AddElementFieldInfo("AttendanceCodeEntity", "Code", typeof(System.String), false, false, false, false,  (int)AttendanceCodeFieldIndex.Code, 50, 0, 0);
			this.AddElementFieldInfo("AttendanceCodeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)AttendanceCodeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("AttendanceCodeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AttendanceCodeFieldIndex.Name, 100, 0, 0);
			this.AddElementFieldInfo("AttendanceCodeEntity", "Status", typeof(System.String), false, false, false, false,  (int)AttendanceCodeFieldIndex.Status, 50, 0, 0);
			this.AddElementFieldInfo("AttendanceCodeEntity", "Type", typeof(System.String), false, false, false, false,  (int)AttendanceCodeFieldIndex.Type, 50, 0, 0);
		}
		/// <summary>Inits ClassRegistrationEntity's FieldInfo objects</summary>
		private void InitClassRegistrationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ClassRegistrationFieldIndex), "ClassRegistrationEntity");
			this.AddElementFieldInfo("ClassRegistrationEntity", "FinalGrade", typeof(System.String), false, false, false, true,  (int)ClassRegistrationFieldIndex.FinalGrade, 50, 0, 0);
			this.AddElementFieldInfo("ClassRegistrationEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ClassRegistrationFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ClassRegistrationEntity", "IsOnline", typeof(System.Boolean), false, false, false, false,  (int)ClassRegistrationFieldIndex.IsOnline, 0, 0, 0);
			this.AddElementFieldInfo("ClassRegistrationEntity", "OfferingId", typeof(System.Int32), false, true, false, false,  (int)ClassRegistrationFieldIndex.OfferingId, 0, 0, 10);
			this.AddElementFieldInfo("ClassRegistrationEntity", "RegistrationDate", typeof(System.DateTime), false, false, false, false,  (int)ClassRegistrationFieldIndex.RegistrationDate, 0, 0, 0);
			this.AddElementFieldInfo("ClassRegistrationEntity", "StudentId", typeof(System.Int32), false, true, false, false,  (int)ClassRegistrationFieldIndex.StudentId, 0, 0, 10);
		}
		/// <summary>Inits CourseEntity's FieldInfo objects</summary>
		private void InitCourseEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CourseFieldIndex), "CourseEntity");
			this.AddElementFieldInfo("CourseEntity", "CourseNumber", typeof(System.String), false, false, false, false,  (int)CourseFieldIndex.CourseNumber, 50, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "Description", typeof(System.String), false, false, false, false,  (int)CourseFieldIndex.Description, 2147483647, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "HasPrerequisite", typeof(System.Boolean), false, false, false, false,  (int)CourseFieldIndex.HasPrerequisite, 0, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CourseFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CourseEntity", "Prerequisite1", typeof(System.String), false, false, false, true,  (int)CourseFieldIndex.Prerequisite1, 50, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "Prerequisite2", typeof(System.String), false, false, false, true,  (int)CourseFieldIndex.Prerequisite2, 50, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "Prerequisite3", typeof(System.String), false, false, false, true,  (int)CourseFieldIndex.Prerequisite3, 50, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "Syllabus", typeof(System.Byte[]), false, false, false, true,  (int)CourseFieldIndex.Syllabus, 2147483647, 0, 0);
			this.AddElementFieldInfo("CourseEntity", "Title", typeof(System.String), false, false, false, false,  (int)CourseFieldIndex.Title, 500, 0, 0);
		}
		/// <summary>Inits GradeBookEntity's FieldInfo objects</summary>
		private void InitGradeBookEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GradeBookFieldIndex), "GradeBookEntity");
			this.AddElementFieldInfo("GradeBookEntity", "GradeItemId", typeof(System.Int32), false, true, false, false,  (int)GradeBookFieldIndex.GradeItemId, 0, 0, 10);
			this.AddElementFieldInfo("GradeBookEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)GradeBookFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("GradeBookEntity", "OfferingId", typeof(System.Int32), false, true, false, false,  (int)GradeBookFieldIndex.OfferingId, 0, 0, 10);
			this.AddElementFieldInfo("GradeBookEntity", "Score", typeof(System.Int32), false, false, false, false,  (int)GradeBookFieldIndex.Score, 0, 0, 10);
			this.AddElementFieldInfo("GradeBookEntity", "StudentId", typeof(System.Int32), false, true, false, false,  (int)GradeBookFieldIndex.StudentId, 0, 0, 10);
			this.AddElementFieldInfo("GradeBookEntity", "SubmitDate", typeof(System.DateTime), false, false, false, false,  (int)GradeBookFieldIndex.SubmitDate, 0, 0, 0);
			this.AddElementFieldInfo("GradeBookEntity", "SubmittedBy", typeof(System.Int32), false, true, false, false,  (int)GradeBookFieldIndex.SubmittedBy, 0, 0, 10);
		}
		/// <summary>Inits GradeItemEntity's FieldInfo objects</summary>
		private void InitGradeItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GradeItemFieldIndex), "GradeItemEntity");
			this.AddElementFieldInfo("GradeItemEntity", "FullScore", typeof(System.Int32), false, false, false, false,  (int)GradeItemFieldIndex.FullScore, 0, 0, 10);
			this.AddElementFieldInfo("GradeItemEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)GradeItemFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("GradeItemEntity", "Name", typeof(System.String), false, false, false, false,  (int)GradeItemFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("GradeItemEntity", "Type", typeof(System.String), false, false, false, false,  (int)GradeItemFieldIndex.Type, 50, 0, 0);
			this.AddElementFieldInfo("GradeItemEntity", "Weight", typeof(System.Int32), false, false, false, false,  (int)GradeItemFieldIndex.Weight, 0, 0, 10);
		}
		/// <summary>Inits OfferingEntity's FieldInfo objects</summary>
		private void InitOfferingEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OfferingFieldIndex), "OfferingEntity");
			this.AddElementFieldInfo("OfferingEntity", "Capacity", typeof(System.Int32), false, false, false, false,  (int)OfferingFieldIndex.Capacity, 0, 0, 10);
			this.AddElementFieldInfo("OfferingEntity", "CourseId", typeof(System.Int32), false, true, false, false,  (int)OfferingFieldIndex.CourseId, 0, 0, 10);
			this.AddElementFieldInfo("OfferingEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)OfferingFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("OfferingEntity", "Instructor2Id", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OfferingFieldIndex.Instructor2Id, 0, 0, 10);
			this.AddElementFieldInfo("OfferingEntity", "InstructorId", typeof(System.Int32), false, true, false, false,  (int)OfferingFieldIndex.InstructorId, 0, 0, 10);
			this.AddElementFieldInfo("OfferingEntity", "RoomNumber", typeof(System.String), false, false, false, false,  (int)OfferingFieldIndex.RoomNumber, 50, 0, 0);
			this.AddElementFieldInfo("OfferingEntity", "SemesterId", typeof(System.Int32), false, true, false, false,  (int)OfferingFieldIndex.SemesterId, 0, 0, 10);
		}
		/// <summary>Inits OfferingScheduleEntity's FieldInfo objects</summary>
		private void InitOfferingScheduleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OfferingScheduleFieldIndex), "OfferingScheduleEntity");
			this.AddElementFieldInfo("OfferingScheduleEntity", "EndTime", typeof(System.TimeSpan), false, false, false, false,  (int)OfferingScheduleFieldIndex.EndTime, 0, 0, 0);
			this.AddElementFieldInfo("OfferingScheduleEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)OfferingScheduleFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("OfferingScheduleEntity", "OfferingId", typeof(System.Int32), false, true, false, false,  (int)OfferingScheduleFieldIndex.OfferingId, 0, 0, 10);
			this.AddElementFieldInfo("OfferingScheduleEntity", "StartTime", typeof(System.TimeSpan), false, false, false, false,  (int)OfferingScheduleFieldIndex.StartTime, 0, 0, 0);
			this.AddElementFieldInfo("OfferingScheduleEntity", "Weekday", typeof(System.String), false, false, false, false,  (int)OfferingScheduleFieldIndex.Weekday, 50, 0, 0);
		}
		/// <summary>Inits SemesterEntity's FieldInfo objects</summary>
		private void InitSemesterEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SemesterFieldIndex), "SemesterEntity");
			this.AddElementFieldInfo("SemesterEntity", "EndDate", typeof(System.DateTime), false, false, false, false,  (int)SemesterFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("SemesterEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)SemesterFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("SemesterEntity", "Name", typeof(System.String), false, false, false, false,  (int)SemesterFieldIndex.Name, 100, 0, 0);
			this.AddElementFieldInfo("SemesterEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)SemesterFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits StudentEntity's FieldInfo objects</summary>
		private void InitStudentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StudentFieldIndex), "StudentEntity");
			this.AddElementFieldInfo("StudentEntity", "Email", typeof(System.String), false, false, false, false,  (int)StudentFieldIndex.Email, 100, 0, 0);
			this.AddElementFieldInfo("StudentEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)StudentFieldIndex.FirstName, 100, 0, 0);
			this.AddElementFieldInfo("StudentEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)StudentFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("StudentEntity", "IsOnline", typeof(System.Boolean), false, false, false, false,  (int)StudentFieldIndex.IsOnline, 0, 0, 0);
			this.AddElementFieldInfo("StudentEntity", "LastName", typeof(System.String), false, false, false, false,  (int)StudentFieldIndex.LastName, 100, 0, 0);
			this.AddElementFieldInfo("StudentEntity", "Status", typeof(System.String), false, false, false, false,  (int)StudentFieldIndex.Status, 100, 0, 0);
			this.AddElementFieldInfo("StudentEntity", "StudentId", typeof(System.Int32), false, false, false, false,  (int)StudentFieldIndex.StudentId, 0, 0, 10);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "Email", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Email, 500, 0, 0);
			this.AddElementFieldInfo("UserEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("UserEntity", "FullName", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.FullName, 500, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "IsAdmin", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsAdmin, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "IsInstructor", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsInstructor, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "LastLoginDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.LastLoginDate, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "LastName", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 500, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RefId", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.RefId, 500, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Username, 500, 0, 0);
		}
		
	}
}




