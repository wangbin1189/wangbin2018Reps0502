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
	/// <summary>Implements the relations factory for the entity: GradeBook. </summary>
	public partial class GradeBookRelations
	{
		/// <summary>CTor</summary>
		public GradeBookRelations()
		{
		}

		/// <summary>Gets all relations of the GradeBookEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.GradeItemEntityUsingGradeItemId);
			toReturn.Add(this.OfferingEntityUsingOfferingId);
			toReturn.Add(this.StudentEntityUsingStudentId);
			toReturn.Add(this.UserEntityUsingSubmittedBy);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between GradeBookEntity and GradeItemEntity over the m:1 relation they have, using the relation between the fields:
		/// GradeBook.GradeItemId - GradeItem.Id
		/// </summary>
		public virtual IEntityRelation GradeItemEntityUsingGradeItemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "GradeItem", false);
				relation.AddEntityFieldPair(GradeItemFields.Id, GradeBookFields.GradeItemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeItemEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between GradeBookEntity and OfferingEntity over the m:1 relation they have, using the relation between the fields:
		/// GradeBook.OfferingId - Offering.Id
		/// </summary>
		public virtual IEntityRelation OfferingEntityUsingOfferingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Offering", false);
				relation.AddEntityFieldPair(OfferingFields.Id, GradeBookFields.OfferingId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between GradeBookEntity and StudentEntity over the m:1 relation they have, using the relation between the fields:
		/// GradeBook.StudentId - Student.Id
		/// </summary>
		public virtual IEntityRelation StudentEntityUsingStudentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Student", false);
				relation.AddEntityFieldPair(StudentFields.Id, GradeBookFields.StudentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StudentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between GradeBookEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// GradeBook.SubmittedBy - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingSubmittedBy
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.Id, GradeBookFields.SubmittedBy);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", true);
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
	internal static class StaticGradeBookRelations
	{
		internal static readonly IEntityRelation GradeItemEntityUsingGradeItemIdStatic = new GradeBookRelations().GradeItemEntityUsingGradeItemId;
		internal static readonly IEntityRelation OfferingEntityUsingOfferingIdStatic = new GradeBookRelations().OfferingEntityUsingOfferingId;
		internal static readonly IEntityRelation StudentEntityUsingStudentIdStatic = new GradeBookRelations().StudentEntityUsingStudentId;
		internal static readonly IEntityRelation UserEntityUsingSubmittedByStatic = new GradeBookRelations().UserEntityUsingSubmittedBy;

		/// <summary>CTor</summary>
		static StaticGradeBookRelations()
		{
		}
	}
}
