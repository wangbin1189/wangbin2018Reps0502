﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: Course. </summary>
	public partial class CourseRelations
	{
		/// <summary>CTor</summary>
		public CourseRelations()
		{
		}

		/// <summary>Gets all relations of the CourseEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OfferingEntityUsingCourseId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CourseEntity and OfferingEntity over the 1:n relation they have, using the relation between the fields:
		/// Course.Id - Offering.CourseId
		/// </summary>
		public virtual IEntityRelation OfferingEntityUsingCourseId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Offerings" , true);
				relation.AddEntityFieldPair(CourseFields.Id, OfferingFields.CourseId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CourseEntity", true);
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
	internal static class StaticCourseRelations
	{
		internal static readonly IEntityRelation OfferingEntityUsingCourseIdStatic = new CourseRelations().OfferingEntityUsingCourseId;

		/// <summary>CTor</summary>
		static StaticCourseRelations()
		{
		}
	}
}
