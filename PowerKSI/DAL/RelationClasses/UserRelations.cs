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
	/// <summary>Implements the relations factory for the entity: User. </summary>
	public partial class UserRelations
	{
		/// <summary>CTor</summary>
		public UserRelations()
		{
		}

		/// <summary>Gets all relations of the UserEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.GradeBookEntityUsingSubmittedBy);
			toReturn.Add(this.OfferingEntityUsingInstructorId);
			toReturn.Add(this.OfferingEntityUsingInstructor2Id);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UserEntity and GradeBookEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - GradeBook.SubmittedBy
		/// </summary>
		public virtual IEntityRelation GradeBookEntityUsingSubmittedBy
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GradeBooks" , true);
				relation.AddEntityFieldPair(UserFields.Id, GradeBookFields.SubmittedBy);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and OfferingEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Offering.InstructorId
		/// </summary>
		public virtual IEntityRelation OfferingEntityUsingInstructorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Offerings" , true);
				relation.AddEntityFieldPair(UserFields.Id, OfferingFields.InstructorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and OfferingEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Offering.Instructor2Id
		/// </summary>
		public virtual IEntityRelation OfferingEntityUsingInstructor2Id
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Offerings1" , true);
				relation.AddEntityFieldPair(UserFields.Id, OfferingFields.Instructor2Id);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", false);
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
	internal static class StaticUserRelations
	{
		internal static readonly IEntityRelation GradeBookEntityUsingSubmittedByStatic = new UserRelations().GradeBookEntityUsingSubmittedBy;
		internal static readonly IEntityRelation OfferingEntityUsingInstructorIdStatic = new UserRelations().OfferingEntityUsingInstructorId;
		internal static readonly IEntityRelation OfferingEntityUsingInstructor2IdStatic = new UserRelations().OfferingEntityUsingInstructor2Id;

		/// <summary>CTor</summary>
		static StaticUserRelations()
		{
		}
	}
}
