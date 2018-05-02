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
	/// <summary>Implements the relations factory for the entity: OfferingSchedule. </summary>
	public partial class OfferingScheduleRelations
	{
		/// <summary>CTor</summary>
		public OfferingScheduleRelations()
		{
		}

		/// <summary>Gets all relations of the OfferingScheduleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OfferingEntityUsingOfferingId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between OfferingScheduleEntity and OfferingEntity over the m:1 relation they have, using the relation between the fields:
		/// OfferingSchedule.OfferingId - Offering.Id
		/// </summary>
		public virtual IEntityRelation OfferingEntityUsingOfferingId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Offering", false);
				relation.AddEntityFieldPair(OfferingFields.Id, OfferingScheduleFields.OfferingId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OfferingScheduleEntity", true);
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
	internal static class StaticOfferingScheduleRelations
	{
		internal static readonly IEntityRelation OfferingEntityUsingOfferingIdStatic = new OfferingScheduleRelations().OfferingEntityUsingOfferingId;

		/// <summary>CTor</summary>
		static StaticOfferingScheduleRelations()
		{
		}
	}
}
