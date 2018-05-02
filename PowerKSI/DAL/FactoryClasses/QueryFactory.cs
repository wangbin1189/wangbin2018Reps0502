///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using KSI.EntityClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace KSI.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField(fieldName, targetAlias, typeof(TValue));
		}
						
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the Attendance entity</summary>
		public EntityQuery<AttendanceEntity> Attendance
		{
			get { return Create<AttendanceEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AttendanceCode entity</summary>
		public EntityQuery<AttendanceCodeEntity> AttendanceCode
		{
			get { return Create<AttendanceCodeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ClassRegistration entity</summary>
		public EntityQuery<ClassRegistrationEntity> ClassRegistration
		{
			get { return Create<ClassRegistrationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Course entity</summary>
		public EntityQuery<CourseEntity> Course
		{
			get { return Create<CourseEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the GradeBook entity</summary>
		public EntityQuery<GradeBookEntity> GradeBook
		{
			get { return Create<GradeBookEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the GradeItem entity</summary>
		public EntityQuery<GradeItemEntity> GradeItem
		{
			get { return Create<GradeItemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Offering entity</summary>
		public EntityQuery<OfferingEntity> Offering
		{
			get { return Create<OfferingEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the OfferingSchedule entity</summary>
		public EntityQuery<OfferingScheduleEntity> OfferingSchedule
		{
			get { return Create<OfferingScheduleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Semester entity</summary>
		public EntityQuery<SemesterEntity> Semester
		{
			get { return Create<SemesterEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Student entity</summary>
		public EntityQuery<StudentEntity> Student
		{
			get { return Create<StudentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User
		{
			get { return Create<UserEntity>(); }
		}


 
	}
}