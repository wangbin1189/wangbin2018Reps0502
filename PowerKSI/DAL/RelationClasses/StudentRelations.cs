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
	/// <summary>Implements the relations factory for the entity: Student. </summary>
	public partial class StudentRelations
	{
		/// <summary>CTor</summary>
		public StudentRelations()
		{
		}

		/// <summary>Gets all relations of the StudentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ClassRegistrationEntityUsingStudentId);
			toReturn.Add(this.GradeBookEntityUsingStudentId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StudentEntity and ClassRegistrationEntity over the 1:n relation they have, using the relation between the fields:
		/// Student.Id - ClassRegistration.StudentId
		/// </summary>
		public virtual IEntityRelation ClassRegistrationEntityUsingStudentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ClassRegistrations" , true);
				relation.AddEntityFieldPair(StudentFields.Id, ClassRegistrationFields.StudentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StudentEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ClassRegistrationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StudentEntity and GradeBookEntity over the 1:n relation they have, using the relation between the fields:
		/// Student.Id - GradeBook.StudentId
		/// </summary>
		public virtual IEntityRelation GradeBookEntityUsingStudentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GradeBooks" , true);
				relation.AddEntityFieldPair(StudentFields.Id, GradeBookFields.StudentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StudentEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GradeBookEntity", false);
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
	internal static class StaticStudentRelations
	{
		internal static readonly IEntityRelation ClassRegistrationEntityUsingStudentIdStatic = new StudentRelations().ClassRegistrationEntityUsingStudentId;
		internal static readonly IEntityRelation GradeBookEntityUsingStudentIdStatic = new StudentRelations().GradeBookEntityUsingStudentId;

		/// <summary>CTor</summary>
		static StaticStudentRelations()
		{
		}
	}
}
