///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using KSI;
using KSI.DaoClasses;
using KSI.EntityClasses;
using KSI.FactoryClasses;
using KSI.HelperClasses;
using KSI.RelationClasses;

namespace KSI.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((KSI.EntityType)typeOfEntity)
			{
				case KSI.EntityType.AttendanceEntity:
					toReturn = this.Attendance;
					break;
				case KSI.EntityType.AttendanceCodeEntity:
					toReturn = this.AttendanceCode;
					break;
				case KSI.EntityType.ClassRegistrationEntity:
					toReturn = this.ClassRegistration;
					break;
				case KSI.EntityType.CourseEntity:
					toReturn = this.Course;
					break;
				case KSI.EntityType.GradeBookEntity:
					toReturn = this.GradeBook;
					break;
				case KSI.EntityType.GradeItemEntity:
					toReturn = this.GradeItem;
					break;
				case KSI.EntityType.OfferingEntity:
					toReturn = this.Offering;
					break;
				case KSI.EntityType.OfferingScheduleEntity:
					toReturn = this.OfferingSchedule;
					break;
				case KSI.EntityType.SemesterEntity:
					toReturn = this.Semester;
					break;
				case KSI.EntityType.StudentEntity:
					toReturn = this.Student;
					break;
				case KSI.EntityType.UserEntity:
					toReturn = this.User;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource<TEntity> GetQueryableForEntity<TEntity>()
			    where TEntity : class
		{
    		return new DataSource<TEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AttendanceEntity instances in the database.</summary>
		public DataSource<AttendanceEntity> Attendance
		{
			get { return new DataSource<AttendanceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AttendanceCodeEntity instances in the database.</summary>
		public DataSource<AttendanceCodeEntity> AttendanceCode
		{
			get { return new DataSource<AttendanceCodeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ClassRegistrationEntity instances in the database.</summary>
		public DataSource<ClassRegistrationEntity> ClassRegistration
		{
			get { return new DataSource<ClassRegistrationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CourseEntity instances in the database.</summary>
		public DataSource<CourseEntity> Course
		{
			get { return new DataSource<CourseEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GradeBookEntity instances in the database.</summary>
		public DataSource<GradeBookEntity> GradeBook
		{
			get { return new DataSource<GradeBookEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GradeItemEntity instances in the database.</summary>
		public DataSource<GradeItemEntity> GradeItem
		{
			get { return new DataSource<GradeItemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting OfferingEntity instances in the database.</summary>
		public DataSource<OfferingEntity> Offering
		{
			get { return new DataSource<OfferingEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting OfferingScheduleEntity instances in the database.</summary>
		public DataSource<OfferingScheduleEntity> OfferingSchedule
		{
			get { return new DataSource<OfferingScheduleEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SemesterEntity instances in the database.</summary>
		public DataSource<SemesterEntity> Semester
		{
			get { return new DataSource<SemesterEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StudentEntity instances in the database.</summary>
		public DataSource<StudentEntity> Student
		{
			get { return new DataSource<StudentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource<UserEntity> User
		{
			get { return new DataSource<UserEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}

		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}