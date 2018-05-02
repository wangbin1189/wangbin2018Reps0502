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

	/// <summary>Entity class which represents the entity 'ClassRegistration'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ClassRegistrationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private OfferingEntity _offering;
		private bool	_alwaysFetchOffering, _alreadyFetchedOffering, _offeringReturnsNewIfNotFound;
		private StudentEntity _student;
		private bool	_alwaysFetchStudent, _alreadyFetchedStudent, _studentReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Offering</summary>
			public static readonly string Offering = "Offering";
			/// <summary>Member name Student</summary>
			public static readonly string Student = "Student";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ClassRegistrationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ClassRegistrationEntity() :base("ClassRegistrationEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		public ClassRegistrationEntity(System.Int32 id):base("ClassRegistrationEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ClassRegistrationEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("ClassRegistrationEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		/// <param name="validator">The custom validator object for this ClassRegistrationEntity</param>
		public ClassRegistrationEntity(System.Int32 id, IValidator validator):base("ClassRegistrationEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ClassRegistrationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_offering = (OfferingEntity)info.GetValue("_offering", typeof(OfferingEntity));
			if(_offering!=null)
			{
				_offering.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_offeringReturnsNewIfNotFound = info.GetBoolean("_offeringReturnsNewIfNotFound");
			_alwaysFetchOffering = info.GetBoolean("_alwaysFetchOffering");
			_alreadyFetchedOffering = info.GetBoolean("_alreadyFetchedOffering");

			_student = (StudentEntity)info.GetValue("_student", typeof(StudentEntity));
			if(_student!=null)
			{
				_student.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_studentReturnsNewIfNotFound = info.GetBoolean("_studentReturnsNewIfNotFound");
			_alwaysFetchStudent = info.GetBoolean("_alwaysFetchStudent");
			_alreadyFetchedStudent = info.GetBoolean("_alreadyFetchedStudent");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ClassRegistrationFieldIndex)fieldIndex)
			{
				case ClassRegistrationFieldIndex.OfferingId:
					DesetupSyncOffering(true, false);
					_alreadyFetchedOffering = false;
					break;
				case ClassRegistrationFieldIndex.StudentId:
					DesetupSyncStudent(true, false);
					_alreadyFetchedStudent = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedOffering = (_offering != null);
			_alreadyFetchedStudent = (_student != null);
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
				case "Offering":
					toReturn.Add(Relations.OfferingEntityUsingOfferingId);
					break;
				case "Student":
					toReturn.Add(Relations.StudentEntityUsingStudentId);
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
			info.AddValue("_offering", (!this.MarkedForDeletion?_offering:null));
			info.AddValue("_offeringReturnsNewIfNotFound", _offeringReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchOffering", _alwaysFetchOffering);
			info.AddValue("_alreadyFetchedOffering", _alreadyFetchedOffering);
			info.AddValue("_student", (!this.MarkedForDeletion?_student:null));
			info.AddValue("_studentReturnsNewIfNotFound", _studentReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchStudent", _alwaysFetchStudent);
			info.AddValue("_alreadyFetchedStudent", _alreadyFetchedStudent);

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
				case "Offering":
					_alreadyFetchedOffering = true;
					this.Offering = (OfferingEntity)entity;
					break;
				case "Student":
					_alreadyFetchedStudent = true;
					this.Student = (StudentEntity)entity;
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
				case "Offering":
					SetupSyncOffering(relatedEntity);
					break;
				case "Student":
					SetupSyncStudent(relatedEntity);
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
				case "Offering":
					DesetupSyncOffering(false, true);
					break;
				case "Student":
					DesetupSyncStudent(false, true);
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
			if(_offering!=null)
			{
				toReturn.Add(_offering);
			}
			if(_student!=null)
			{
				toReturn.Add(_student);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
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
			return new ClassRegistrationRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'OfferingEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'OfferingEntity' which is related to this entity.</returns>
		public OfferingEntity GetSingleOffering()
		{
			return GetSingleOffering(false);
		}

		/// <summary> Retrieves the related entity of type 'OfferingEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'OfferingEntity' which is related to this entity.</returns>
		public virtual OfferingEntity GetSingleOffering(bool forceFetch)
		{
			if( ( !_alreadyFetchedOffering || forceFetch || _alwaysFetchOffering) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.OfferingEntityUsingOfferingId);
				OfferingEntity newEntity = new OfferingEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.OfferingId);
				}
				if(fetchResult)
				{
					newEntity = (OfferingEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_offeringReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Offering = newEntity;
				_alreadyFetchedOffering = fetchResult;
			}
			return _offering;
		}


		/// <summary> Retrieves the related entity of type 'StudentEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'StudentEntity' which is related to this entity.</returns>
		public StudentEntity GetSingleStudent()
		{
			return GetSingleStudent(false);
		}

		/// <summary> Retrieves the related entity of type 'StudentEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'StudentEntity' which is related to this entity.</returns>
		public virtual StudentEntity GetSingleStudent(bool forceFetch)
		{
			if( ( !_alreadyFetchedStudent || forceFetch || _alwaysFetchStudent) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.StudentEntityUsingStudentId);
				StudentEntity newEntity = new StudentEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.StudentId);
				}
				if(fetchResult)
				{
					newEntity = (StudentEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_studentReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Student = newEntity;
				_alreadyFetchedStudent = fetchResult;
			}
			return _student;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Offering", _offering);
			toReturn.Add("Student", _student);
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
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
		/// <param name="validator">The validator object for this ClassRegistrationEntity</param>
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
			_offeringReturnsNewIfNotFound = false;
			_studentReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FinalGrade", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsOnline", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OfferingId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RegistrationDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StudentId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _offering</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncOffering(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _offering, new PropertyChangedEventHandler( OnOfferingPropertyChanged ), "Offering", KSI.RelationClasses.StaticClassRegistrationRelations.OfferingEntityUsingOfferingIdStatic, true, signalRelatedEntity, "ClassRegistrations", resetFKFields, new int[] { (int)ClassRegistrationFieldIndex.OfferingId } );		
			_offering = null;
		}
		
		/// <summary> setups the sync logic for member _offering</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncOffering(IEntityCore relatedEntity)
		{
			if(_offering!=relatedEntity)
			{		
				DesetupSyncOffering(true, true);
				_offering = (OfferingEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _offering, new PropertyChangedEventHandler( OnOfferingPropertyChanged ), "Offering", KSI.RelationClasses.StaticClassRegistrationRelations.OfferingEntityUsingOfferingIdStatic, true, ref _alreadyFetchedOffering, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnOfferingPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _student</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStudent(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _student, new PropertyChangedEventHandler( OnStudentPropertyChanged ), "Student", KSI.RelationClasses.StaticClassRegistrationRelations.StudentEntityUsingStudentIdStatic, true, signalRelatedEntity, "ClassRegistrations", resetFKFields, new int[] { (int)ClassRegistrationFieldIndex.StudentId } );		
			_student = null;
		}
		
		/// <summary> setups the sync logic for member _student</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStudent(IEntityCore relatedEntity)
		{
			if(_student!=relatedEntity)
			{		
				DesetupSyncStudent(true, true);
				_student = (StudentEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _student, new PropertyChangedEventHandler( OnStudentPropertyChanged ), "Student", KSI.RelationClasses.StaticClassRegistrationRelations.StudentEntityUsingStudentIdStatic, true, ref _alreadyFetchedStudent, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStudentPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for ClassRegistration which data should be fetched into this ClassRegistration object</param>
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
				this.Fields[(int)ClassRegistrationFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateClassRegistrationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ClassRegistrationEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ClassRegistrationRelations Relations
		{
			get	{ return new ClassRegistrationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Offering'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOffering
		{
			get	{ return new PrefetchPathElement(new KSI.CollectionClasses.OfferingCollection(), (IEntityRelation)GetRelationsForField("Offering")[0], (int)KSI.EntityType.ClassRegistrationEntity, (int)KSI.EntityType.OfferingEntity, 0, null, null, null, "Offering", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Student'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStudent
		{
			get	{ return new PrefetchPathElement(new KSI.CollectionClasses.StudentCollection(), (IEntityRelation)GetRelationsForField("Student")[0], (int)KSI.EntityType.ClassRegistrationEntity, (int)KSI.EntityType.StudentEntity, 0, null, null, null, "Student", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FinalGrade property of the Entity ClassRegistration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ClassRegistration"."FinalGrade"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FinalGrade
		{
			get { return (System.String)GetValue((int)ClassRegistrationFieldIndex.FinalGrade, true); }
			set	{ SetValue((int)ClassRegistrationFieldIndex.FinalGrade, value, true); }
		}

		/// <summary> The Id property of the Entity ClassRegistration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ClassRegistration"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)ClassRegistrationFieldIndex.Id, true); }
			set	{ SetValue((int)ClassRegistrationFieldIndex.Id, value, true); }
		}

		/// <summary> The IsOnline property of the Entity ClassRegistration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ClassRegistration"."IsOnline"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsOnline
		{
			get { return (System.Boolean)GetValue((int)ClassRegistrationFieldIndex.IsOnline, true); }
			set	{ SetValue((int)ClassRegistrationFieldIndex.IsOnline, value, true); }
		}

		/// <summary> The OfferingId property of the Entity ClassRegistration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ClassRegistration"."OfferingId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 OfferingId
		{
			get { return (System.Int32)GetValue((int)ClassRegistrationFieldIndex.OfferingId, true); }
			set	{ SetValue((int)ClassRegistrationFieldIndex.OfferingId, value, true); }
		}

		/// <summary> The RegistrationDate property of the Entity ClassRegistration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ClassRegistration"."RegistrationDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime RegistrationDate
		{
			get { return (System.DateTime)GetValue((int)ClassRegistrationFieldIndex.RegistrationDate, true); }
			set	{ SetValue((int)ClassRegistrationFieldIndex.RegistrationDate, value, true); }
		}

		/// <summary> The StudentId property of the Entity ClassRegistration<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ClassRegistration"."StudentId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StudentId
		{
			get { return (System.Int32)GetValue((int)ClassRegistrationFieldIndex.StudentId, true); }
			set	{ SetValue((int)ClassRegistrationFieldIndex.StudentId, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'OfferingEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleOffering()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual OfferingEntity Offering
		{
			get	{ return GetSingleOffering(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncOffering(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ClassRegistrations", "Offering", _offering, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Offering. When set to true, Offering is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Offering is accessed. You can always execute a forced fetch by calling GetSingleOffering(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOffering
		{
			get	{ return _alwaysFetchOffering; }
			set	{ _alwaysFetchOffering = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Offering already has been fetched. Setting this property to false when Offering has been fetched
		/// will set Offering to null as well. Setting this property to true while Offering hasn't been fetched disables lazy loading for Offering</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOffering
		{
			get { return _alreadyFetchedOffering;}
			set 
			{
				if(_alreadyFetchedOffering && !value)
				{
					this.Offering = null;
				}
				_alreadyFetchedOffering = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Offering is not found
		/// in the database. When set to true, Offering will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool OfferingReturnsNewIfNotFound
		{
			get	{ return _offeringReturnsNewIfNotFound; }
			set { _offeringReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'StudentEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStudent()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StudentEntity Student
		{
			get	{ return GetSingleStudent(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncStudent(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ClassRegistrations", "Student", _student, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Student. When set to true, Student is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Student is accessed. You can always execute a forced fetch by calling GetSingleStudent(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStudent
		{
			get	{ return _alwaysFetchStudent; }
			set	{ _alwaysFetchStudent = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Student already has been fetched. Setting this property to false when Student has been fetched
		/// will set Student to null as well. Setting this property to true while Student hasn't been fetched disables lazy loading for Student</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStudent
		{
			get { return _alreadyFetchedStudent;}
			set 
			{
				if(_alreadyFetchedStudent && !value)
				{
					this.Student = null;
				}
				_alreadyFetchedStudent = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Student is not found
		/// in the database. When set to true, Student will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool StudentReturnsNewIfNotFound
		{
			get	{ return _studentReturnsNewIfNotFound; }
			set { _studentReturnsNewIfNotFound = value; }	
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
			get { return (int)KSI.EntityType.ClassRegistrationEntity; }
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
