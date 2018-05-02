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
using System.Collections;
using System.Collections.Generic;
using KSI;
using KSI.FactoryClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace KSI.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Offering. </summary>
	public partial class OfferingRelations
	{
		/// <summary>CTor</summary>
		public OfferingRelations()
		{
		}

		/// <summary>Gets all relations of the OfferingEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ClassRegistrationEntityUsingOfferingId);
			toReturn.Add(this.GradeBookEntityUsingOfferingId);
			toReturn.Add(this.OfferingScheduleEntityUsingOfferingId);
			toReturn.Add(this.CourseEntityUsingCourseId);
			toReturn.Add(this.SemesterEntityUsingSemesterId);
			toReturn.Add(this.UserEntityUsingInstructorId);
			toReturn.Add(this.UserEntityUsingInstructor2Id);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and ClassRegistrationEntity over the 1:n relation they have, using the relation between the fields:
		/// Offering.Id - ClassRegistration.OfferingId
		/// </summary>
		public virtual IEntityRelation ClassRegistrationEntityUsingOfferingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ClassRegistrations" , true);
				relation.AddEntityFieldPair(OfferingFields.Id, ClassRegistrationFields.OfferingId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ClassRegistrationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and GradeBookEntity over the 1:n relation they have, using the relation between the fields:
		/// Offering.Id - GradeBook.OfferingId
		/// </summary>
		public virtual IEntityRelation GradeBookEntityUsingOfferingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GradeBooks" , true);
				relation.AddEntityFieldPair(OfferingFields.Id, GradeBookFields.OfferingId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and OfferingScheduleEntity over the 1:n relation they have, using the relation between the fields:
		/// Offering.Id - OfferingSchedule.OfferingId
		/// </summary>
		public virtual IEntityRelation OfferingScheduleEntityUsingOfferingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "OfferingSchedules" , true);
				relation.AddEntityFieldPair(OfferingFields.Id, OfferingScheduleFields.OfferingId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingScheduleEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and CourseEntity over the m:1 relation they have, using the relation between the fields:
		/// Offering.CourseId - Course.Id
		/// </summary>
		public virtual IEntityRelation CourseEntityUsingCourseId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Course", false);
				relation.AddEntityFieldPair(CourseFields.Id, OfferingFields.CourseId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CourseEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and SemesterEntity over the m:1 relation they have, using the relation between the fields:
		/// Offering.SemesterId - Semester.Id
		/// </summary>
		public virtual IEntityRelation SemesterEntityUsingSemesterId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Semester", false);
				relation.AddEntityFieldPair(SemesterFields.Id, OfferingFields.SemesterId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SemesterEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Offering.InstructorId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingInstructorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.Id, OfferingFields.InstructorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OfferingEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Offering.Instructor2Id - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingInstructor2Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User1", false);
				relation.AddEntityFieldPair(UserFields.Id, OfferingFields.Instructor2Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOfferingRelations
	{
		internal static readonly IEntityRelation ClassRegistrationEntityUsingOfferingIdStatic = new OfferingRelations().ClassRegistrationEntityUsingOfferingId;
		internal static readonly IEntityRelation GradeBookEntityUsingOfferingIdStatic = new OfferingRelations().GradeBookEntityUsingOfferingId;
		internal static readonly IEntityRelation OfferingScheduleEntityUsingOfferingIdStatic = new OfferingRelations().OfferingScheduleEntityUsingOfferingId;
		internal static readonly IEntityRelation CourseEntityUsingCourseIdStatic = new OfferingRelations().CourseEntityUsingCourseId;
		internal static readonly IEntityRelation SemesterEntityUsingSemesterIdStatic = new OfferingRelations().SemesterEntityUsingSemesterId;
		internal static readonly IEntityRelation UserEntityUsingInstructorIdStatic = new OfferingRelations().UserEntityUsingInstructorId;
		internal static readonly IEntityRelation UserEntityUsingInstructor2IdStatic = new OfferingRelations().UserEntityUsingInstructor2Id;

		/// <summary>CTor</summary>
		static StaticOfferingRelations()
		{
		}
	}
}
