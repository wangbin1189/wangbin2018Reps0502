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

namespace KSI
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Attendance.</summary>
	public enum AttendanceFieldIndex
	{
		///<summary>AttendanceCodeId. </summary>
		AttendanceCodeId,
		///<summary>DateOfAttendance. </summary>
		DateOfAttendance,
		///<summary>Notes. </summary>
		Notes,
		///<summary>OfferingId. </summary>
		OfferingId,
		///<summary>StudentId. </summary>
		StudentId,
		///<summary>SubmitDate. </summary>
		SubmitDate,
		///<summary>SubmittedBy. </summary>
		SubmittedBy,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AttendanceCode.</summary>
	public enum AttendanceCodeFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>Status. </summary>
		Status,
		///<summary>Type. </summary>
		Type,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ClassRegistration.</summary>
	public enum ClassRegistrationFieldIndex
	{
		///<summary>FinalGrade. </summary>
		FinalGrade,
		///<summary>Id. </summary>
		Id,
		///<summary>IsOnline. </summary>
		IsOnline,
		///<summary>OfferingId. </summary>
		OfferingId,
		///<summary>RegistrationDate. </summary>
		RegistrationDate,
		///<summary>StudentId. </summary>
		StudentId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Course.</summary>
	public enum CourseFieldIndex
	{
		///<summary>CourseNumber. </summary>
		CourseNumber,
		///<summary>Description. </summary>
		Description,
		///<summary>HasPrerequisite. </summary>
		HasPrerequisite,
		///<summary>Id. </summary>
		Id,
		///<summary>Prerequisite1. </summary>
		Prerequisite1,
		///<summary>Prerequisite2. </summary>
		Prerequisite2,
		///<summary>Prerequisite3. </summary>
		Prerequisite3,
		///<summary>Syllabus. </summary>
		Syllabus,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: GradeBook.</summary>
	public enum GradeBookFieldIndex
	{
		///<summary>GradeItemId. </summary>
		GradeItemId,
		///<summary>Id. </summary>
		Id,
		///<summary>OfferingId. </summary>
		OfferingId,
		///<summary>Score. </summary>
		Score,
		///<summary>StudentId. </summary>
		StudentId,
		///<summary>SubmitDate. </summary>
		SubmitDate,
		///<summary>SubmittedBy. </summary>
		SubmittedBy,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: GradeItem.</summary>
	public enum GradeItemFieldIndex
	{
		///<summary>FullScore. </summary>
		FullScore,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>Type. </summary>
		Type,
		///<summary>Weight. </summary>
		Weight,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Offering.</summary>
	public enum OfferingFieldIndex
	{
		///<summary>Capacity. </summary>
		Capacity,
		///<summary>CourseId. </summary>
		CourseId,
		///<summary>Id. </summary>
		Id,
		///<summary>Instructor2Id. </summary>
		Instructor2Id,
		///<summary>InstructorId. </summary>
		InstructorId,
		///<summary>RoomNumber. </summary>
		RoomNumber,
		///<summary>SemesterId. </summary>
		SemesterId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OfferingSchedule.</summary>
	public enum OfferingScheduleFieldIndex
	{
		///<summary>EndTime. </summary>
		EndTime,
		///<summary>Id. </summary>
		Id,
		///<summary>OfferingId. </summary>
		OfferingId,
		///<summary>StartTime. </summary>
		StartTime,
		///<summary>Weekday. </summary>
		Weekday,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Semester.</summary>
	public enum SemesterFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Student.</summary>
	public enum StudentFieldIndex
	{
		///<summary>Email. </summary>
		Email,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>Id. </summary>
		Id,
		///<summary>IsOnline. </summary>
		IsOnline,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Status. </summary>
		Status,
		///<summary>StudentId. </summary>
		StudentId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: User.</summary>
	public enum UserFieldIndex
	{
		///<summary>Email. </summary>
		Email,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>FullName. </summary>
		FullName,
		///<summary>Id. </summary>
		Id,
		///<summary>IsAdmin. </summary>
		IsAdmin,
		///<summary>IsInstructor. </summary>
		IsInstructor,
		///<summary>LastLoginDate. </summary>
		LastLoginDate,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Password. </summary>
		Password,
		///<summary>RefId. </summary>
		RefId,
		///<summary>Username. </summary>
		Username,
		/// <summary></summary>
		AmountOfFields
	}



	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Attendance</summary>
		AttendanceEntity,
		///<summary>AttendanceCode</summary>
		AttendanceCodeEntity,
		///<summary>ClassRegistration</summary>
		ClassRegistrationEntity,
		///<summary>Course</summary>
		CourseEntity,
		///<summary>GradeBook</summary>
		GradeBookEntity,
		///<summary>GradeItem</summary>
		GradeItemEntity,
		///<summary>Offering</summary>
		OfferingEntity,
		///<summary>OfferingSchedule</summary>
		OfferingScheduleEntity,
		///<summary>Semester</summary>
		SemesterEntity,
		///<summary>Student</summary>
		StudentEntity,
		///<summary>User</summary>
		UserEntity
	}


	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

