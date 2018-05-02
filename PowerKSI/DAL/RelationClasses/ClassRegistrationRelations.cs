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
	/// <summary>Implements the relations factory for the entity: ClassRegistration. </summary>
	public partial class ClassRegistrationRelations
	{
		/// <summary>CTor</summary>
		public ClassRegistrationRelations()
		{
		}

		/// <summary>Gets all relations of the ClassRegistrationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OfferingEntityUsingOfferingId);
			toReturn.Add(this.StudentEntityUsingStudentId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ClassRegistrationEntity and OfferingEntity over the m:1 relation they have, using the relation between the fields:
		/// ClassRegistration.OfferingId - Offering.Id
		/// </summary>
		public virtual IEntityRelation OfferingEntityUsingOfferingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Offering", false);
				relation.AddEntityFieldPair(OfferingFields.Id, ClassRegistrationFields.OfferingId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ClassRegistrationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ClassRegistrationEntity and StudentEntity over the m:1 relation they have, using the relation between the fields:
		/// ClassRegistration.StudentId - Student.Id
		/// </summary>
		public virtual IEntityRelation StudentEntityUsingStudentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Student", false);
				relation.AddEntityFieldPair(StudentFields.Id, ClassRegistrationFields.StudentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StudentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ClassRegistrationEntity", true);
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
	internal static class StaticClassRegistrationRelations
	{
		internal static readonly IEntityRelation OfferingEntityUsingOfferingIdStatic = new ClassRegistrationRelations().OfferingEntityUsingOfferingId;
		internal static readonly IEntityRelation StudentEntityUsingStudentIdStatic = new ClassRegistrationRelations().StudentEntityUsingStudentId;

		/// <summary>CTor</summary>
		static StaticClassRegistrationRelations()
		{
		}
	}
}
