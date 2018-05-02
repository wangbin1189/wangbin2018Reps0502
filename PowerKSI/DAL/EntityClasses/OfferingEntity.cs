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

	/// <summary>Entity class which represents the entity 'Offering'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class OfferingEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private KSI.CollectionClasses.ClassRegistrationCollection	_classRegistrations;
		private bool	_alwaysFetchClassRegistrations, _alreadyFetchedClassRegistrations;
		private KSI.CollectionClasses.GradeBookCollection	_gradeBooks;
		private bool	_alwaysFetchGradeBooks, _alreadyFetchedGradeBooks;
		private KSI.CollectionClasses.OfferingScheduleCollection	_offeringSchedules;
		private bool	_alwaysFetchOfferingSchedules, _alreadyFetchedOfferingSchedules;
		private CourseEntity _course;
		private bool	_alwaysFetchCourse, _alreadyFetchedCourse, _courseReturnsNewIfNotFound;
		private SemesterEntity _semester;
		private bool	_alwaysFetchSemester, _alreadyFetchedSemester, _semesterReturnsNewIfNotFound;
		private UserEntity _user;
		private bool	_alwaysFetchUser, _alreadyFetchedUser, _userReturnsNewIfNotFound;
		private UserEntity _user1;
		private bool	_alwaysFetchUser1, _alreadyFetchedUser1, _user1ReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Course</summary>
			public static readonly string Course = "Course";
			/// <summary>Member name Semester</summary>
			public static readonly string Semester = "Semester";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
			/// <summary>Member name User1</summary>
			public static readonly string User1 = "User1";
			/// <summary>Member name ClassRegistrations</summary>
			public static readonly string ClassRegistrations = "ClassRegistrations";
			/// <summary>Member name GradeBooks</summary>
			public static readonly string GradeBooks = "GradeBooks";
			/// <summary>Member name OfferingSchedules</summary>
			public static readonly string OfferingSchedules = "OfferingSchedules";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static OfferingEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public OfferingEntity() :base("OfferingEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		public OfferingEntity(System.Int32 id):base("OfferingEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public OfferingEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("OfferingEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		/// <param name="validator">The custom validator object for this OfferingEntity</param>
		public OfferingEntity(System.Int32 id, IValidator validator):base("OfferingEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OfferingEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_classRegistrations = (KSI.CollectionClasses.ClassRegistrationCollection)info.GetValue("_classRegistrations", typeof(KSI.CollectionClasses.ClassRegistrationCollection));
			_alwaysFetchClassRegistrations = info.GetBoolean("_alwaysFetchClassRegistrations");
			_alreadyFetchedClassRegistrations = info.GetBoolean("_alreadyFetchedClassRegistrations");

			_gradeBooks = (KSI.CollectionClasses.GradeBookCollection)info.GetValue("_gradeBooks", typeof(KSI.CollectionClasses.GradeBookCollection));
			_alwaysFetchGradeBooks = info.GetBoolean("_alwaysFetchGradeBooks");
			_alreadyFetchedGradeBooks = info.GetBoolean("_alreadyFetchedGradeBooks");

			_offeringSchedules = (KSI.CollectionClasses.OfferingScheduleCollection)info.GetValue("_offeringSchedules", typeof(KSI.CollectionClasses.OfferingScheduleCollection));
			_alwaysFetchOfferingSchedules = info.GetBoolean("_alwaysFetchOfferingSchedules");
			_alreadyFetchedOfferingSchedules = info.GetBoolean("_alreadyFetchedOfferingSchedules");
			_course = (CourseEntity)info.GetValue("_course", typeof(CourseEntity));
			if(_course!=null)
			{
				_course.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_courseReturnsNewIfNotFound = info.GetBoolean("_courseReturnsNewIfNotFound");
			_alwaysFetchCourse = info.GetBoolean("_alwaysFetchCourse");
			_alreadyFetchedCourse = info.GetBoolean("_alreadyFetchedCourse");

			_semester = (SemesterEntity)info.GetValue("_semester", typeof(SemesterEntity));
			if(_semester!=null)
			{
				_semester.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_semesterReturnsNewIfNotFound = info.GetBoolean("_semesterReturnsNewIfNotFound");
			_alwaysFetchSemester = info.GetBoolean("_alwaysFetchSemester");
			_alreadyFetchedSemester = info.GetBoolean("_alreadyFetchedSemester");

			_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
			if(_user!=null)
			{
				_user.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userReturnsNewIfNotFound = info.GetBoolean("_userReturnsNewIfNotFound");
			_alwaysFetchUser = info.GetBoolean("_alwaysFetchUser");
			_alreadyFetchedUser = info.GetBoolean("_alreadyFetchedUser");

			_user1 = (UserEntity)info.GetValue("_user1", typeof(UserEntity));
			if(_user1!=null)
			{
				_user1.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_user1ReturnsNewIfNotFound = info.GetBoolean("_user1ReturnsNewIfNotFound");
			_alwaysFetchUser1 = info.GetBoolean("_alwaysFetchUser1");
			_alreadyFetchedUser1 = info.GetBoolean("_alreadyFetchedUser1");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((OfferingFieldIndex)fieldIndex)
			{
				case OfferingFieldIndex.CourseId:
					DesetupSyncCourse(true, false);
					_alreadyFetchedCourse = false;
					break;
				case OfferingFieldIndex.Instructor2Id:
					DesetupSyncUser1(true, false);
					_alreadyFetchedUser1 = false;
					break;
				case OfferingFieldIndex.InstructorId:
					DesetupSyncUser(true, false);
					_alreadyFetchedUser = false;
					break;
				case OfferingFieldIndex.SemesterId:
					DesetupSyncSemester(true, false);
					_alreadyFetchedSemester = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedClassRegistrations = (_classRegistrations.Count > 0);
			_alreadyFetchedGradeBooks = (_gradeBooks.Count > 0);
			_alreadyFetchedOfferingSchedules = (_offeringSchedules.Count > 0);
			_alreadyFetchedCourse = (_course != null);
			_alreadyFetchedSemester = (_semester != null);
			_alreadyFetchedUser = (_user != null);
			_alreadyFetchedUser1 = (_user1 != null);
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
				case "Course":
					toReturn.Add(Relations.CourseEntityUsingCourseId);
					break;
				case "Semester":
					toReturn.Add(Relations.SemesterEntityUsingSemesterId);
					break;
				case "User":
					toReturn.Add(Relations.UserEntityUsingInstructorId);
					break;
				case "User1":
					toReturn.Add(Relations.UserEntityUsingInstructor2Id);
					break;
				case "ClassRegistrations":
					toReturn.Add(Relations.ClassRegistrationEntityUsingOfferingId);
					break;
				case "GradeBooks":
					toReturn.Add(Relations.GradeBookEntityUsingOfferingId);
					break;
				case "OfferingSchedules":
					toReturn.Add(Relations.OfferingScheduleEntityUsingOfferingId);
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
			info.AddValue("_classRegistrations", (!this.MarkedForDeletion?_classRegistrations:null));
			info.AddValue("_alwaysFetchClassRegistrations", _alwaysFetchClassRegistrations);
			info.AddValue("_alreadyFetchedClassRegistrations", _alreadyFetchedClassRegistrations);
			info.AddValue("_gradeBooks", (!this.MarkedForDeletion?_gradeBooks:null));
			info.AddValue("_alwaysFetchGradeBooks", _alwaysFetchGradeBooks);
			info.AddValue("_alreadyFetchedGradeBooks", _alreadyFetchedGradeBooks);
			info.AddValue("_offeringSchedules", (!this.MarkedForDeletion?_offeringSchedules:null));
			info.AddValue("_alwaysFetchOfferingSchedules", _alwaysFetchOfferingSchedules);
			info.AddValue("_alreadyFetchedOfferingSchedules", _alreadyFetchedOfferingSchedules);
			info.AddValue("_course", (!this.MarkedForDeletion?_course:null));
			info.AddValue("_courseReturnsNewIfNotFound", _courseReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCourse", _alwaysFetchCourse);
			info.AddValue("_alreadyFetchedCourse", _alreadyFetchedCourse);
			info.AddValue("_semester", (!this.MarkedForDeletion?_semester:null));
			info.AddValue("_semesterReturnsNewIfNotFound", _semesterReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSemester", _alwaysFetchSemester);
			info.AddValue("_alreadyFetchedSemester", _alreadyFetchedSemester);
			info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
			info.AddValue("_userReturnsNewIfNotFound", _userReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser", _alwaysFetchUser);
			info.AddValue("_alreadyFetchedUser", _alreadyFetchedUser);
			info.AddValue("_user1", (!this.MarkedForDeletion?_user1:null));
			info.AddValue("_user1ReturnsNewIfNotFound", _user1ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser1", _alwaysFetchUser1);
			info.AddValue("_alreadyFetchedUser1", _alreadyFetchedUser1);

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
				case "Course":
					_alreadyFetchedCourse = true;
					this.Course = (CourseEntity)entity;
					break;
				case "Semester":
					_alreadyFetchedSemester = true;
					this.Semester = (SemesterEntity)entity;
					break;
				case "User":
					_alreadyFetchedUser = true;
					this.User = (UserEntity)entity;
					break;
				case "User1":
					_alreadyFetchedUser1 = true;
					this.User1 = (UserEntity)entity;
					break;
				case "ClassRegistrations":
					_alreadyFetchedClassRegistrations = true;
					if(entity!=null)
					{
						this.ClassRegistrations.Add((ClassRegistrationEntity)entity);
					}
					break;
				case "GradeBooks":
					_alreadyFetchedGradeBooks = true;
					if(entity!=null)
					{
						this.GradeBooks.Add((GradeBookEntity)entity);
					}
					break;
				case "OfferingSchedules":
					_alreadyFetchedOfferingSchedules = true;
					if(entity!=null)
					{
						this.OfferingSchedules.Add((OfferingScheduleEntity)entity);
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
				case "Course":
					SetupSyncCourse(relatedEntity);
					break;
				case "Semester":
					SetupSyncSemester(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				case "User1":
					SetupSyncUser1(relatedEntity);
					break;
				case "ClassRegistrations":
					_classRegistrations.Add((ClassRegistrationEntity)relatedEntity);
					break;
				case "GradeBooks":
					_gradeBooks.Add((GradeBookEntity)relatedEntity);
					break;
				case "OfferingSchedules":
					_offeringSchedules.Add((OfferingScheduleEntity)relatedEntity);
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
				case "Course":
					DesetupSyncCourse(false, true);
					break;
				case "Semester":
					DesetupSyncSemester(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				case "User1":
					DesetupSyncUser1(false, true);
					break;
				case "ClassRegistrations":
					this.PerformRelatedEntityRemoval(_classRegistrations, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "GradeBooks":
					this.PerformRelatedEntityRemoval(_gradeBooks, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "OfferingSchedules":
					this.PerformRelatedEntityRemoval(_offeringSchedules, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_course!=null)
			{
				toReturn.Add(_course);
			}
			if(_semester!=null)
			{
				toReturn.Add(_semester);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
			}
			if(_user1!=null)
			{
				toReturn.Add(_user1);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_classRegistrations);
			toReturn.Add(_gradeBooks);
			toReturn.Add(_offeringSchedules);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
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
			return new OfferingRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ClassRegistrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ClassRegistrationEntity'</returns>
		public KSI.CollectionClasses.ClassRegistrationCollection GetMultiClassRegistrations(bool forceFetch)
		{
			return GetMultiClassRegistrations(forceFetch, _classRegistrations.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ClassRegistrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ClassRegistrationEntity'</returns>
		public KSI.CollectionClasses.ClassRegistrationCollection GetMultiClassRegistrations(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiClassRegistrations(forceFetch, _classRegistrations.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ClassRegistrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public KSI.CollectionClasses.ClassRegistrationCollection GetMultiClassRegistrations(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiClassRegistrations(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ClassRegistrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual KSI.CollectionClasses.ClassRegistrationCollection GetMultiClassRegistrations(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedClassRegistrations || forceFetch || _alwaysFetchClassRegistrations) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_classRegistrations);
				_classRegistrations.SuppressClearInGetMulti=!forceFetch;
				_classRegistrations.EntityFactoryToUse = entityFactoryToUse;
				_classRegistrations.GetMultiManyToOne(this, null, filter);
				_classRegistrations.SuppressClearInGetMulti=false;
				_alreadyFetchedClassRegistrations = true;
			}
			return _classRegistrations;
		}

		/// <summary> Sets the collection parameters for the collection for 'ClassRegistrations'. These settings will be taken into account
		/// when the property ClassRegistrations is requested or GetMultiClassRegistrations is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersClassRegistrations(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_classRegistrations.SortClauses=sortClauses;
			_classRegistrations.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_gradeBooks.GetMultiManyToOne(null, this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'OfferingScheduleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OfferingScheduleEntity'</returns>
		public KSI.CollectionClasses.OfferingScheduleCollection GetMultiOfferingSchedules(bool forceFetch)
		{
			return GetMultiOfferingSchedules(forceFetch, _offeringSchedules.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OfferingScheduleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OfferingScheduleEntity'</returns>
		public KSI.CollectionClasses.OfferingScheduleCollection GetMultiOfferingSchedules(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOfferingSchedules(forceFetch, _offeringSchedules.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OfferingScheduleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public KSI.CollectionClasses.OfferingScheduleCollection GetMultiOfferingSchedules(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOfferingSchedules(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OfferingScheduleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual KSI.CollectionClasses.OfferingScheduleCollection GetMultiOfferingSchedules(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOfferingSchedules || forceFetch || _alwaysFetchOfferingSchedules) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_offeringSchedules);
				_offeringSchedules.SuppressClearInGetMulti=!forceFetch;
				_offeringSchedules.EntityFactoryToUse = entityFactoryToUse;
				_offeringSchedules.GetMultiManyToOne(this, filter);
				_offeringSchedules.SuppressClearInGetMulti=false;
				_alreadyFetchedOfferingSchedules = true;
			}
			return _offeringSchedules;
		}

		/// <summary> Sets the collection parameters for the collection for 'OfferingSchedules'. These settings will be taken into account
		/// when the property OfferingSchedules is requested or GetMultiOfferingSchedules is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOfferingSchedules(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_offeringSchedules.SortClauses=sortClauses;
			_offeringSchedules.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'CourseEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CourseEntity' which is related to this entity.</returns>
		public CourseEntity GetSingleCourse()
		{
			return GetSingleCourse(false);
		}

		/// <summary> Retrieves the related entity of type 'CourseEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CourseEntity' which is related to this entity.</returns>
		public virtual CourseEntity GetSingleCourse(bool forceFetch)
		{
			if( ( !_alreadyFetchedCourse || forceFetch || _alwaysFetchCourse) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CourseEntityUsingCourseId);
				CourseEntity newEntity = new CourseEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CourseId);
				}
				if(fetchResult)
				{
					newEntity = (CourseEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_courseReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Course = newEntity;
				_alreadyFetchedCourse = fetchResult;
			}
			return _course;
		}


		/// <summary> Retrieves the related entity of type 'SemesterEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SemesterEntity' which is related to this entity.</returns>
		public SemesterEntity GetSingleSemester()
		{
			return GetSingleSemester(false);
		}

		/// <summary> Retrieves the related entity of type 'SemesterEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SemesterEntity' which is related to this entity.</returns>
		public virtual SemesterEntity GetSingleSemester(bool forceFetch)
		{
			if( ( !_alreadyFetchedSemester || forceFetch || _alwaysFetchSemester) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SemesterEntityUsingSemesterId);
				SemesterEntity newEntity = new SemesterEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SemesterId);
				}
				if(fetchResult)
				{
					newEntity = (SemesterEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_semesterReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Semester = newEntity;
				_alreadyFetchedSemester = fetchResult;
			}
			return _semester;
		}


		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public UserEntity GetSingleUser()
		{
			return GetSingleUser(false);
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser(bool forceFetch)
		{
			if( ( !_alreadyFetchedUser || forceFetch || _alwaysFetchUser) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UserEntityUsingInstructorId);
				UserEntity newEntity = new UserEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.InstructorId);
				}
				if(fetchResult)
				{
					newEntity = (UserEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_userReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.User = newEntity;
				_alreadyFetchedUser = fetchResult;
			}
			return _user;
		}


		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public UserEntity GetSingleUser1()
		{
			return GetSingleUser1(false);
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser1(bool forceFetch)
		{
			if( ( !_alreadyFetchedUser1 || forceFetch || _alwaysFetchUser1) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UserEntityUsingInstructor2Id);
				UserEntity newEntity = new UserEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.Instructor2Id.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (UserEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_user1ReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.User1 = newEntity;
				_alreadyFetchedUser1 = fetchResult;
			}
			return _user1;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Course", _course);
			toReturn.Add("Semester", _semester);
			toReturn.Add("User", _user);
			toReturn.Add("User1", _user1);
			toReturn.Add("ClassRegistrations", _classRegistrations);
			toReturn.Add("GradeBooks", _gradeBooks);
			toReturn.Add("OfferingSchedules", _offeringSchedules);
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
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
		/// <param name="validator">The validator object for this OfferingEntity</param>
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

			_classRegistrations = new KSI.CollectionClasses.ClassRegistrationCollection();
			_classRegistrations.SetContainingEntityInfo(this, "Offering");

			_gradeBooks = new KSI.CollectionClasses.GradeBookCollection();
			_gradeBooks.SetContainingEntityInfo(this, "Offering");

			_offeringSchedules = new KSI.CollectionClasses.OfferingScheduleCollection();
			_offeringSchedules.SetContainingEntityInfo(this, "Offering");
			_courseReturnsNewIfNotFound = false;
			_semesterReturnsNewIfNotFound = false;
			_userReturnsNewIfNotFound = false;
			_user1ReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("Capacity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CourseId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Instructor2Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("InstructorId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RoomNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SemesterId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _course</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCourse(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _course, new PropertyChangedEventHandler( OnCoursePropertyChanged ), "Course", KSI.RelationClasses.StaticOfferingRelations.CourseEntityUsingCourseIdStatic, true, signalRelatedEntity, "Offerings", resetFKFields, new int[] { (int)OfferingFieldIndex.CourseId } );		
			_course = null;
		}
		
		/// <summary> setups the sync logic for member _course</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCourse(IEntityCore relatedEntity)
		{
			if(_course!=relatedEntity)
			{		
				DesetupSyncCourse(true, true);
				_course = (CourseEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _course, new PropertyChangedEventHandler( OnCoursePropertyChanged ), "Course", KSI.RelationClasses.StaticOfferingRelations.CourseEntityUsingCourseIdStatic, true, ref _alreadyFetchedCourse, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCoursePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _semester</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSemester(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _semester, new PropertyChangedEventHandler( OnSemesterPropertyChanged ), "Semester", KSI.RelationClasses.StaticOfferingRelations.SemesterEntityUsingSemesterIdStatic, true, signalRelatedEntity, "Offerings", resetFKFields, new int[] { (int)OfferingFieldIndex.SemesterId } );		
			_semester = null;
		}
		
		/// <summary> setups the sync logic for member _semester</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSemester(IEntityCore relatedEntity)
		{
			if(_semester!=relatedEntity)
			{		
				DesetupSyncSemester(true, true);
				_semester = (SemesterEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _semester, new PropertyChangedEventHandler( OnSemesterPropertyChanged ), "Semester", KSI.RelationClasses.StaticOfferingRelations.SemesterEntityUsingSemesterIdStatic, true, ref _alreadyFetchedSemester, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSemesterPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", KSI.RelationClasses.StaticOfferingRelations.UserEntityUsingInstructorIdStatic, true, signalRelatedEntity, "Offerings", resetFKFields, new int[] { (int)OfferingFieldIndex.InstructorId } );		
			_user = null;
		}
		
		/// <summary> setups the sync logic for member _user</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser(IEntityCore relatedEntity)
		{
			if(_user!=relatedEntity)
			{		
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", KSI.RelationClasses.StaticOfferingRelations.UserEntityUsingInstructorIdStatic, true, ref _alreadyFetchedUser, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user1</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser1(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user1, new PropertyChangedEventHandler( OnUser1PropertyChanged ), "User1", KSI.RelationClasses.StaticOfferingRelations.UserEntityUsingInstructor2IdStatic, true, signalRelatedEntity, "Offerings1", resetFKFields, new int[] { (int)OfferingFieldIndex.Instructor2Id } );		
			_user1 = null;
		}
		
		/// <summary> setups the sync logic for member _user1</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser1(IEntityCore relatedEntity)
		{
			if(_user1!=relatedEntity)
			{		
				DesetupSyncUser1(true, true);
				_user1 = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user1, new PropertyChangedEventHandler( OnUser1PropertyChanged ), "User1", KSI.RelationClasses.StaticOfferingRelations.UserEntityUsingInstructor2IdStatic, true, ref _alreadyFetchedUser1, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUser1PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Offering which data should be fetched into this Offering object</param>
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
				this.Fields[(int)OfferingFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateOfferingDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new OfferingEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static OfferingRelations Relations
		{
			get	{ return new OfferingRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ClassRegistration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathClassRegistrations
		{
			get { return new PrefetchPathElement(new KSI.CollectionClasses.ClassRegistrationCollection(), (IEntityRelation)GetRelationsForField("ClassRegistrations")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.ClassRegistrationEntity, 0, null, null, null, "ClassRegistrations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GradeBook' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGradeBooks
		{
			get { return new PrefetchPathElement(new KSI.CollectionClasses.GradeBookCollection(), (IEntityRelation)GetRelationsForField("GradeBooks")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.GradeBookEntity, 0, null, null, null, "GradeBooks", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OfferingSchedule' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOfferingSchedules
		{
			get { return new PrefetchPathElement(new KSI.CollectionClasses.OfferingScheduleCollection(), (IEntityRelation)GetRelationsForField("OfferingSchedules")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.OfferingScheduleEntity, 0, null, null, null, "OfferingSchedules", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Course'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCourse
		{
			get	{ return new PrefetchPathElement(new KSI.CollectionClasses.CourseCollection(), (IEntityRelation)GetRelationsForField("Course")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.CourseEntity, 0, null, null, null, "Course", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Semester'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSemester
		{
			get	{ return new PrefetchPathElement(new KSI.CollectionClasses.SemesterCollection(), (IEntityRelation)GetRelationsForField("Semester")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.SemesterEntity, 0, null, null, null, "Semester", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser
		{
			get	{ return new PrefetchPathElement(new KSI.CollectionClasses.UserCollection(), (IEntityRelation)GetRelationsForField("User")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser1
		{
			get	{ return new PrefetchPathElement(new KSI.CollectionClasses.UserCollection(), (IEntityRelation)GetRelationsForField("User1")[0], (int)KSI.EntityType.OfferingEntity, (int)KSI.EntityType.UserEntity, 0, null, null, null, "User1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Capacity property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."Capacity"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Capacity
		{
			get { return (System.Int32)GetValue((int)OfferingFieldIndex.Capacity, true); }
			set	{ SetValue((int)OfferingFieldIndex.Capacity, value, true); }
		}

		/// <summary> The CourseId property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."CourseId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CourseId
		{
			get { return (System.Int32)GetValue((int)OfferingFieldIndex.CourseId, true); }
			set	{ SetValue((int)OfferingFieldIndex.CourseId, value, true); }
		}

		/// <summary> The Id property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)OfferingFieldIndex.Id, true); }
			set	{ SetValue((int)OfferingFieldIndex.Id, value, true); }
		}

		/// <summary> The Instructor2Id property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."Instructor2Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Instructor2Id
		{
			get { return (Nullable<System.Int32>)GetValue((int)OfferingFieldIndex.Instructor2Id, false); }
			set	{ SetValue((int)OfferingFieldIndex.Instructor2Id, value, true); }
		}

		/// <summary> The InstructorId property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."InstructorId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 InstructorId
		{
			get { return (System.Int32)GetValue((int)OfferingFieldIndex.InstructorId, true); }
			set	{ SetValue((int)OfferingFieldIndex.InstructorId, value, true); }
		}

		/// <summary> The RoomNumber property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."RoomNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String RoomNumber
		{
			get { return (System.String)GetValue((int)OfferingFieldIndex.RoomNumber, true); }
			set	{ SetValue((int)OfferingFieldIndex.RoomNumber, value, true); }
		}

		/// <summary> The SemesterId property of the Entity Offering<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Offering"."SemesterId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 SemesterId
		{
			get { return (System.Int32)GetValue((int)OfferingFieldIndex.SemesterId, true); }
			set	{ SetValue((int)OfferingFieldIndex.SemesterId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ClassRegistrationEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiClassRegistrations()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual KSI.CollectionClasses.ClassRegistrationCollection ClassRegistrations
		{
			get	{ return GetMultiClassRegistrations(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ClassRegistrations. When set to true, ClassRegistrations is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ClassRegistrations is accessed. You can always execute/ a forced fetch by calling GetMultiClassRegistrations(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchClassRegistrations
		{
			get	{ return _alwaysFetchClassRegistrations; }
			set	{ _alwaysFetchClassRegistrations = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ClassRegistrations already has been fetched. Setting this property to false when ClassRegistrations has been fetched
		/// will clear the ClassRegistrations collection well. Setting this property to true while ClassRegistrations hasn't been fetched disables lazy loading for ClassRegistrations</summary>
		[Browsable(false)]
		public bool AlreadyFetchedClassRegistrations
		{
			get { return _alreadyFetchedClassRegistrations;}
			set 
			{
				if(_alreadyFetchedClassRegistrations && !value && (_classRegistrations != null))
				{
					_classRegistrations.Clear();
				}
				_alreadyFetchedClassRegistrations = value;
			}
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
		/// <summary> Retrieves all related entities of type 'OfferingScheduleEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOfferingSchedules()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual KSI.CollectionClasses.OfferingScheduleCollection OfferingSchedules
		{
			get	{ return GetMultiOfferingSchedules(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for OfferingSchedules. When set to true, OfferingSchedules is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OfferingSchedules is accessed. You can always execute/ a forced fetch by calling GetMultiOfferingSchedules(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOfferingSchedules
		{
			get	{ return _alwaysFetchOfferingSchedules; }
			set	{ _alwaysFetchOfferingSchedules = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property OfferingSchedules already has been fetched. Setting this property to false when OfferingSchedules has been fetched
		/// will clear the OfferingSchedules collection well. Setting this property to true while OfferingSchedules hasn't been fetched disables lazy loading for OfferingSchedules</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOfferingSchedules
		{
			get { return _alreadyFetchedOfferingSchedules;}
			set 
			{
				if(_alreadyFetchedOfferingSchedules && !value && (_offeringSchedules != null))
				{
					_offeringSchedules.Clear();
				}
				_alreadyFetchedOfferingSchedules = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'CourseEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCourse()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CourseEntity Course
		{
			get	{ return GetSingleCourse(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCourse(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Offerings", "Course", _course, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Course. When set to true, Course is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Course is accessed. You can always execute a forced fetch by calling GetSingleCourse(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCourse
		{
			get	{ return _alwaysFetchCourse; }
			set	{ _alwaysFetchCourse = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Course already has been fetched. Setting this property to false when Course has been fetched
		/// will set Course to null as well. Setting this property to true while Course hasn't been fetched disables lazy loading for Course</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCourse
		{
			get { return _alreadyFetchedCourse;}
			set 
			{
				if(_alreadyFetchedCourse && !value)
				{
					this.Course = null;
				}
				_alreadyFetchedCourse = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Course is not found
		/// in the database. When set to true, Course will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CourseReturnsNewIfNotFound
		{
			get	{ return _courseReturnsNewIfNotFound; }
			set { _courseReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'SemesterEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSemester()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SemesterEntity Semester
		{
			get	{ return GetSingleSemester(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSemester(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Offerings", "Semester", _semester, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Semester. When set to true, Semester is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Semester is accessed. You can always execute a forced fetch by calling GetSingleSemester(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSemester
		{
			get	{ return _alwaysFetchSemester; }
			set	{ _alwaysFetchSemester = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Semester already has been fetched. Setting this property to false when Semester has been fetched
		/// will set Semester to null as well. Setting this property to true while Semester hasn't been fetched disables lazy loading for Semester</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSemester
		{
			get { return _alreadyFetchedSemester;}
			set 
			{
				if(_alreadyFetchedSemester && !value)
				{
					this.Semester = null;
				}
				_alreadyFetchedSemester = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Semester is not found
		/// in the database. When set to true, Semester will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool SemesterReturnsNewIfNotFound
		{
			get	{ return _semesterReturnsNewIfNotFound; }
			set { _semesterReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUser()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get	{ return GetSingleUser(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Offerings", "User", _user, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for User. When set to true, User is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User is accessed. You can always execute a forced fetch by calling GetSingleUser(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser
		{
			get	{ return _alwaysFetchUser; }
			set	{ _alwaysFetchUser = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User already has been fetched. Setting this property to false when User has been fetched
		/// will set User to null as well. Setting this property to true while User hasn't been fetched disables lazy loading for User</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser
		{
			get { return _alreadyFetchedUser;}
			set 
			{
				if(_alreadyFetchedUser && !value)
				{
					this.User = null;
				}
				_alreadyFetchedUser = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property User is not found
		/// in the database. When set to true, User will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool UserReturnsNewIfNotFound
		{
			get	{ return _userReturnsNewIfNotFound; }
			set { _userReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUser1()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserEntity User1
		{
			get	{ return GetSingleUser1(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUser1(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Offerings1", "User1", _user1, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for User1. When set to true, User1 is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User1 is accessed. You can always execute a forced fetch by calling GetSingleUser1(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser1
		{
			get	{ return _alwaysFetchUser1; }
			set	{ _alwaysFetchUser1 = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User1 already has been fetched. Setting this property to false when User1 has been fetched
		/// will set User1 to null as well. Setting this property to true while User1 hasn't been fetched disables lazy loading for User1</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser1
		{
			get { return _alreadyFetchedUser1;}
			set 
			{
				if(_alreadyFetchedUser1 && !value)
				{
					this.User1 = null;
				}
				_alreadyFetchedUser1 = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property User1 is not found
		/// in the database. When set to true, User1 will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool User1ReturnsNewIfNotFound
		{
			get	{ return _user1ReturnsNewIfNotFound; }
			set { _user1ReturnsNewIfNotFound = value; }	
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
			get { return (int)KSI.EntityType.OfferingEntity; }
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
