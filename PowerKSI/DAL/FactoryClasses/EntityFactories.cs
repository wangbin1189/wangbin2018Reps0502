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
using System.Collections.Generic;
using KSI.HelperClasses;
using KSI.RelationClasses;
using KSI.DaoClasses;

using KSI.EntityClasses;
using KSI.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace KSI.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly KSI.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, KSI.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((KSI.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty AttendanceEntity objects.</summary>
	[Serializable]
	public partial class AttendanceEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AttendanceEntityFactory() : base("AttendanceEntity", KSI.EntityType.AttendanceEntity) { }

		/// <summary>Creates a new, empty AttendanceEntity object.</summary>
		/// <returns>A new, empty AttendanceEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AttendanceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAttendance
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AttendanceCodeEntity objects.</summary>
	[Serializable]
	public partial class AttendanceCodeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AttendanceCodeEntityFactory() : base("AttendanceCodeEntity", KSI.EntityType.AttendanceCodeEntity) { }

		/// <summary>Creates a new, empty AttendanceCodeEntity object.</summary>
		/// <returns>A new, empty AttendanceCodeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AttendanceCodeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAttendanceCode
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ClassRegistrationEntity objects.</summary>
	[Serializable]
	public partial class ClassRegistrationEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ClassRegistrationEntityFactory() : base("ClassRegistrationEntity", KSI.EntityType.ClassRegistrationEntity) { }

		/// <summary>Creates a new, empty ClassRegistrationEntity object.</summary>
		/// <returns>A new, empty ClassRegistrationEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ClassRegistrationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewClassRegistration
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CourseEntity objects.</summary>
	[Serializable]
	public partial class CourseEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CourseEntityFactory() : base("CourseEntity", KSI.EntityType.CourseEntity) { }

		/// <summary>Creates a new, empty CourseEntity object.</summary>
		/// <returns>A new, empty CourseEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CourseEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCourse
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GradeBookEntity objects.</summary>
	[Serializable]
	public partial class GradeBookEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GradeBookEntityFactory() : base("GradeBookEntity", KSI.EntityType.GradeBookEntity) { }

		/// <summary>Creates a new, empty GradeBookEntity object.</summary>
		/// <returns>A new, empty GradeBookEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GradeBookEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGradeBook
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GradeItemEntity objects.</summary>
	[Serializable]
	public partial class GradeItemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GradeItemEntityFactory() : base("GradeItemEntity", KSI.EntityType.GradeItemEntity) { }

		/// <summary>Creates a new, empty GradeItemEntity object.</summary>
		/// <returns>A new, empty GradeItemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GradeItemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGradeItem
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty OfferingEntity objects.</summary>
	[Serializable]
	public partial class OfferingEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public OfferingEntityFactory() : base("OfferingEntity", KSI.EntityType.OfferingEntity) { }

		/// <summary>Creates a new, empty OfferingEntity object.</summary>
		/// <returns>A new, empty OfferingEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new OfferingEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOffering
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty OfferingScheduleEntity objects.</summary>
	[Serializable]
	public partial class OfferingScheduleEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public OfferingScheduleEntityFactory() : base("OfferingScheduleEntity", KSI.EntityType.OfferingScheduleEntity) { }

		/// <summary>Creates a new, empty OfferingScheduleEntity object.</summary>
		/// <returns>A new, empty OfferingScheduleEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new OfferingScheduleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOfferingSchedule
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SemesterEntity objects.</summary>
	[Serializable]
	public partial class SemesterEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SemesterEntityFactory() : base("SemesterEntity", KSI.EntityType.SemesterEntity) { }

		/// <summary>Creates a new, empty SemesterEntity object.</summary>
		/// <returns>A new, empty SemesterEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SemesterEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSemester
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StudentEntity objects.</summary>
	[Serializable]
	public partial class StudentEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StudentEntityFactory() : base("StudentEntity", KSI.EntityType.StudentEntity) { }

		/// <summary>Creates a new, empty StudentEntity object.</summary>
		/// <returns>A new, empty StudentEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StudentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStudent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserEntityFactory() : base("UserEntity", KSI.EntityType.UserEntity) { }

		/// <summary>Creates a new, empty UserEntity object.</summary>
		/// <returns>A new, empty UserEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(KSI.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case KSI.EntityType.AttendanceEntity:
					return new AttendanceCollection();
				case KSI.EntityType.AttendanceCodeEntity:
					return new AttendanceCodeCollection();
				case KSI.EntityType.ClassRegistrationEntity:
					return new ClassRegistrationCollection();
				case KSI.EntityType.CourseEntity:
					return new CourseCollection();
				case KSI.EntityType.GradeBookEntity:
					return new GradeBookCollection();
				case KSI.EntityType.GradeItemEntity:
					return new GradeItemCollection();
				case KSI.EntityType.OfferingEntity:
					return new OfferingCollection();
				case KSI.EntityType.OfferingScheduleEntity:
					return new OfferingScheduleCollection();
				case KSI.EntityType.SemesterEntity:
					return new SemesterCollection();
				case KSI.EntityType.StudentEntity:
					return new StudentCollection();
				case KSI.EntityType.UserEntity:
					return new UserCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(KSI.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case KSI.EntityType.AttendanceEntity:
					factoryToUse = new AttendanceEntityFactory();
					break;
				case KSI.EntityType.AttendanceCodeEntity:
					factoryToUse = new AttendanceCodeEntityFactory();
					break;
				case KSI.EntityType.ClassRegistrationEntity:
					factoryToUse = new ClassRegistrationEntityFactory();
					break;
				case KSI.EntityType.CourseEntity:
					factoryToUse = new CourseEntityFactory();
					break;
				case KSI.EntityType.GradeBookEntity:
					factoryToUse = new GradeBookEntityFactory();
					break;
				case KSI.EntityType.GradeItemEntity:
					factoryToUse = new GradeItemEntityFactory();
					break;
				case KSI.EntityType.OfferingEntity:
					factoryToUse = new OfferingEntityFactory();
					break;
				case KSI.EntityType.OfferingScheduleEntity:
					factoryToUse = new OfferingScheduleEntityFactory();
					break;
				case KSI.EntityType.SemesterEntity:
					factoryToUse = new SemesterEntityFactory();
					break;
				case KSI.EntityType.StudentEntity:
					factoryToUse = new StudentEntityFactory();
					break;
				case KSI.EntityType.UserEntity:
					factoryToUse = new UserEntityFactory();
					break;
			}
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(KSI.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((KSI.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the KSI.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(KSI.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the KSI.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}


		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (KSI.EntityType)Enum.Parse(typeof(KSI.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((KSI.EntityType)Enum.Parse(typeof(KSI.EntityType), leftOperandEntityName, false), joinType, (KSI.EntityType)Enum.Parse(typeof(KSI.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (KSI.EntityType)Enum.Parse(typeof(KSI.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the KSI.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((KSI.EntityType)entityTypeValue);
		}
	
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

	}
}
