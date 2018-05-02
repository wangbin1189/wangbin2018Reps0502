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
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using KSI;
using KSI.FactoryClasses;
using KSI.DaoClasses;
using KSI.RelationClasses;
using KSI.HelperClasses;
using KSI.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace KSI.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'User'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private KSI.CollectionClasses.GradeBookCollection	_gradeBooks;
		private bool	_alwaysFetchGradeBooks, _alreadyFetchedGradeBooks;
		private KSI.CollectionClasses.OfferingCollection	_offerings;
		private bool	_alwaysFetchOfferings, _alreadyFetchedOfferings;
		private KSI.CollectionClasses.OfferingCollection	_offerings1;
		private bool	_alwaysFetchOfferings1, _alreadyFetchedOfferings1;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name GradeBooks</summary>
			public static readonly string GradeBooks = "GradeBooks";
			/// <summary>Member name Offerings</summary>
			public static readonly string Offerings = "Offerings";
			/// <summary>Member name Offerings1</summary>
			public static readonly string Offerings1 = "Offerings1";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UserEntity() :base("UserEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.Int32 id):base("UserEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UserEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("UserEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.Int32 id, IValidator validator):base("UserEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_gradeBooks = (KSI.CollectionClasses.GradeBookCollection)info.GetValue("_gradeBooks", typeof(KSI.CollectionClasses.GradeBookCollection));
			_alwaysFetchGradeBooks = info.GetBoolean("_alwaysFetchGradeBooks");
			_alreadyFetchedGradeBooks = info.GetBoolean("_alreadyFetchedGradeBooks");

			_offerings = (KSI.CollectionClasses.OfferingCollection)info.GetValue("_offerings", typeof(KSI.CollectionClasses.OfferingCollection));
			_alwaysFetchOfferings = info.GetBoolean("_alwaysFetchOfferings");
			_alreadyFetchedOfferings = info.GetBoolean("_alreadyFetchedOfferings");

			_offerings1 = (KSI.CollectionClasses.OfferingCollection)info.GetValue("_offerings1", typeof(KSI.CollectionClasses.OfferingCollection));
			_alwaysFetchOfferings1 = info.GetBoolean("_alwaysFetchOfferings1");
			_alreadyFetchedOfferings1 = info.GetBoolean("_alreadyFetchedOfferings1");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedGradeBooks = (_gradeBooks.Count > 0);
			_alreadyFetchedOfferings = (_offerings.Count > 0);
			_alreadyFetchedOfferings1 = (_offerings1.Count > 0);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "GradeBooks":
					toReturn.Add(Relations.GradeBookEntityUsingSubmittedBy);
					break;
				case "Offerings":
					toReturn.Add(Relations.OfferingEntityUsingInstructorId);
					break;
				case "Offerings1":
					toReturn.Add(Relations.OfferingEntityUsingInstructor2Id);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_gradeBooks", (!this.MarkedForDeletion?_gradeBooks:null));
			info.AddValue("_alwaysFetchGradeBooks", _alwaysFetchGradeBooks);
			info.AddValue("_alreadyFetchedGradeBooks", _alreadyFetchedGradeBooks);
			info.AddValue("_offerings", (!this.MarkedForDeletion?_offerings:null));
			info.AddValue("_alwaysFetchOfferings", _alwaysFetchOfferings);
			info.AddValue("_alreadyFetchedOfferings", _alreadyFetchedOfferings);
			info.AddValue("_offerings1", (!this.MarkedForDeletion?_offerings1:null));
			info.AddValue("_alwaysFetchOfferings1", _alwaysFetchOfferings1);
			info.AddValue("_alreadyFetchedOfferings1", _alreadyFetchedOfferings1);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "GradeBooks":
					_alreadyFetchedGradeBooks = true;
					if(entity!=null)
					{
						this.GradeBooks.Add((GradeBookEntity)entity);
					}
					break;
				case "Offerings":
					_alreadyFetchedOfferings = true;
					if(entity!=null)
					{
						this.Offerings.Add((OfferingEntity)entity);
					}
					break;
				case "Offerings1":
					_alreadyFetchedOfferings1 = true;
					if(entity!=null)
					{
						this.Offerings1.Add((OfferingEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "GradeBooks":
					_gradeBooks.Add((GradeBookEntity)relatedEntity);
					break;
				case "Offerings":
					_offerings.Add((OfferingEntity)relatedEntity);
					break;
				case "Offerings1":
					_offerings1.Add((OfferingEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "GradeBooks":
					this.PerformRelatedEntityRemoval(_gradeBooks, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Offerings":
					this.PerformRelatedEntityRemoval(_offerings, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Offerings1":
					this.PerformRelatedEntityRemoval(_offerings1, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_gradeBooks);
			toReturn.Add(_offerings);
			toReturn.Add(_offerings1);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(id, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Id, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UserRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'GradeBookEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'GradeBookEntity'</returns>
		public KSI.CollectionClasses.GradeBookCollection GetMultiGradeBooks(bool forceFetch)
		{
			return GetMultiGradeBooks(forceFetch, _gradeBooks.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'GradeBookEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'GradeBookEntity'</returns>
		public KSI.CollectionClasses.GradeBookCollection GetMultiGradeBooks(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiGradeBooks(forceFetch, _gradeBooks.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'GradeBookEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public KSI.CollectionClasses.GradeBookCollection GetMultiGradeBooks(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiGradeBooks(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'GradeBookEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual KSI.CollectionClasses.GradeBookCollection GetMultiGradeBooks(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedGradeBooks || forceFetch || _alwaysFetchGradeBooks) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_gradeBooks);
				_gradeBooks.SuppressClearInGetMulti=!forceFetch;
				_gradeBooks.EntityFactoryToUse = entityFactoryToUse;
				_gradeBooks.GetMultiManyToOne(null, null, null, this, filter);
				_gradeBooks.SuppressClearInGetMulti=false;
				_alreadyFetchedGradeBooks = true;
			}
			return _gradeBooks;
		}

		/// <summary> Sets the collection parameters for the collection for 'GradeBooks'. These settings will be taken into account
		/// when the property GradeBooks is requested or GetMultiGradeBooks is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersGradeBooks(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_gradeBooks.SortClauses=sortClauses;
			_gradeBooks.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OfferingEntity'</returns>
		public KSI.CollectionClasses.OfferingCollection GetMultiOfferings(bool forceFetch)
		{
			return GetMultiOfferings(forceFetch, _offerings.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OfferingEntity'</returns>
		public KSI.CollectionClasses.OfferingCollection GetMultiOfferings(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOfferings(forceFetch, _offerings.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public KSI.CollectionClasses.OfferingCollection GetMultiOfferings(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOfferings(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual KSI.CollectionClasses.OfferingCollection GetMultiOfferings(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOfferings || forceFetch || _alwaysFetchOfferings) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_offerings);
				_offerings.SuppressClearInGetMulti=!forceFetch;
				_offerings.EntityFactoryToUse = entityFactoryToUse;
				_offerings.GetMultiManyToOne(null, null, this, null, filter);
				_offerings.SuppressClearInGetMulti=false;
				_alreadyFetchedOfferings = true;
			}
			return _offerings;
		}

		/// <summary> Sets the collection parameters for the collection for 'Offerings'. These settings will be taken into account
		/// when the property Offerings is requested or GetMultiOfferings is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOfferings(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_offerings.SortClauses=sortClauses;
			_offerings.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OfferingEntity'</returns>
		public KSI.CollectionClasses.OfferingCollection GetMultiOfferings1(bool forceFetch)
		{
			return GetMultiOfferings1(forceFetch, _offerings1.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OfferingEntity'</returns>
		public KSI.CollectionClasses.OfferingCollection GetMultiOfferings1(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOfferings1(forceFetch, _offerings1.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public KSI.CollectionClasses.OfferingCollection GetMultiOfferings1(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOfferings1(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual KSI.CollectionClasses.OfferingCollection GetMultiOfferings1(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOfferings1 || forceFetch || _alwaysFetchOfferings1) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_offerings1);
				_offerings1.SuppressClearInGetMulti=!forceFetch;
				_offerings1.EntityFactoryToUse = entityFactoryToUse;
				_offerings1.GetMultiManyToOne(null, null, null, this, filter);
				_offerings1.SuppressClearInGetMulti=false;
				_alreadyFetchedOfferings1 = true;
			}
			return _offerings1;
		}

		/// <summary> Sets the collection parameters for the collection for 'Offerings1'. These settings will be taken into account
		/// when the property Offerings1 is requested or GetMultiOfferings1 is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOfferings1(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_offerings1.SortClauses=sortClauses;
			_offerings1.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("GradeBooks", _gradeBooks);
			toReturn.Add("Offerings", _offerings);
			toReturn.Add("Offerings1", _offerings1);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 id, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(id, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_gradeBooks = new KSI.CollectionClasses.GradeBookCollection();
			_gradeBooks.SetContainingEntityInfo(this, "User");

			_offerings = new KSI.CollectionClasses.OfferingCollection();
			_offerings.SetContainingEntityInfo(this, "User");

			_offerings1 = new KSI.CollectionClasses.OfferingCollection();
			_offerings1.SetContainingEntityInfo(this, "User1");
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Email", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FullName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsAdmin", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsInstructor", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastLoginDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RefId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Username", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)UserFieldIndex.Id].ForcedCurrentValueWrite(id);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateUserDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UserEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UserRelations Relations
		{
			get	{ return new UserRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GradeBook' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGradeBooks
		{
			get { return new PrefetchPathElement(new KSI.CollectionClasses.GradeBookCollection(), (IEntityRelation)GetRelationsForField("GradeBooks")[0], (int)KSI.EntityType.UserEntity, (int)KSI.EntityType.GradeBookEntity, 0, null, null, null, "GradeBooks", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Offering' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOfferings
		{
			get { return new PrefetchPathElement(new KSI.CollectionClasses.OfferingCollection(), (IEntityRelation)GetRelationsForField("Offerings")[0], (int)KSI.EntityType.UserEntity, (int)KSI.EntityType.OfferingEntity, 0, null, null, null, "Offerings", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Offering' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOfferings1
		{
			get { return new PrefetchPathElement(new KSI.CollectionClasses.OfferingCollection(), (IEntityRelation)GetRelationsForField("Offerings1")[0], (int)KSI.EntityType.UserEntity, (int)KSI.EntityType.OfferingEntity, 0, null, null, null, "Offerings1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Email property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Email
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Email, true); }
			set	{ SetValue((int)UserFieldIndex.Email, value, true); }
		}

		/// <summary> The FirstName property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.FirstName, true); }
			set	{ SetValue((int)UserFieldIndex.FirstName, value, true); }
		}

		/// <summary> The FullName property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."FullName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FullName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.FullName, true); }
			set	{ SetValue((int)UserFieldIndex.FullName, value, true); }
		}

		/// <summary> The Id property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.Id, true); }
			set	{ SetValue((int)UserFieldIndex.Id, value, true); }
		}

		/// <summary> The IsAdmin property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."IsAdmin"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsAdmin
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsAdmin, true); }
			set	{ SetValue((int)UserFieldIndex.IsAdmin, value, true); }
		}

		/// <summary> The IsInstructor property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."IsInstructor"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsInstructor
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsInstructor, true); }
			set	{ SetValue((int)UserFieldIndex.IsInstructor, value, true); }
		}

		/// <summary> The LastLoginDate property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."LastLoginDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> LastLoginDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserFieldIndex.LastLoginDate, false); }
			set	{ SetValue((int)UserFieldIndex.LastLoginDate, value, true); }
		}

		/// <summary> The LastName property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.LastName, true); }
			set	{ SetValue((int)UserFieldIndex.LastName, value, true); }
		}

		/// <summary> The Password property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value, true); }
		}

		/// <summary> The RefId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."RefId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String RefId
		{
			get { return (System.String)GetValue((int)UserFieldIndex.RefId, true); }
			set	{ SetValue((int)UserFieldIndex.RefId, value, true); }
		}

		/// <summary> The Username property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Username, true); }
			set	{ SetValue((int)UserFieldIndex.Username, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'GradeBookEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiGradeBooks()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual KSI.CollectionClasses.GradeBookCollection GradeBooks
		{
			get	{ return GetMultiGradeBooks(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for GradeBooks. When set to true, GradeBooks is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time GradeBooks is accessed. You can always execute/ a forced fetch by calling GetMultiGradeBooks(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchGradeBooks
		{
			get	{ return _alwaysFetchGradeBooks; }
			set	{ _alwaysFetchGradeBooks = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property GradeBooks already has been fetched. Setting this property to false when GradeBooks has been fetched
		/// will clear the GradeBooks collection well. Setting this property to true while GradeBooks hasn't been fetched disables lazy loading for GradeBooks</summary>
		[Browsable(false)]
		public bool AlreadyFetchedGradeBooks
		{
			get { return _alreadyFetchedGradeBooks;}
			set 
			{
				if(_alreadyFetchedGradeBooks && !value && (_gradeBooks != null))
				{
					_gradeBooks.Clear();
				}
				_alreadyFetchedGradeBooks = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOfferings()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual KSI.CollectionClasses.OfferingCollection Offerings
		{
			get	{ return GetMultiOfferings(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Offerings. When set to true, Offerings is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Offerings is accessed. You can always execute/ a forced fetch by calling GetMultiOfferings(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOfferings
		{
			get	{ return _alwaysFetchOfferings; }
			set	{ _alwaysFetchOfferings = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Offerings already has been fetched. Setting this property to false when Offerings has been fetched
		/// will clear the Offerings collection well. Setting this property to true while Offerings hasn't been fetched disables lazy loading for Offerings</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOfferings
		{
			get { return _alreadyFetchedOfferings;}
			set 
			{
				if(_alreadyFetchedOfferings && !value && (_offerings != null))
				{
					_offerings.Clear();
				}
				_alreadyFetchedOfferings = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'OfferingEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOfferings1()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual KSI.CollectionClasses.OfferingCollection Offerings1
		{
			get	{ return GetMultiOfferings1(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Offerings1. When set to true, Offerings1 is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Offerings1 is accessed. You can always execute/ a forced fetch by calling GetMultiOfferings1(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOfferings1
		{
			get	{ return _alwaysFetchOfferings1; }
			set	{ _alwaysFetchOfferings1 = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Offerings1 already has been fetched. Setting this property to false when Offerings1 has been fetched
		/// will clear the Offerings1 collection well. Setting this property to true while Offerings1 hasn't been fetched disables lazy loading for Offerings1</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOfferings1
		{
			get { return _alreadyFetchedOfferings1;}
			set 
			{
				if(_alreadyFetchedOfferings1 && !value && (_offerings1 != null))
				{
					_offerings1.Clear();
				}
				_alreadyFetchedOfferings1 = value;
			}
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the KSI.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)KSI.EntityType.UserEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
