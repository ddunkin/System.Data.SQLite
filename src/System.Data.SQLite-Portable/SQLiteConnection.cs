using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.SQLite
{
	public sealed class SQLiteConnection : DbConnection
	{
		public SQLiteConnection()
		{
		}

		public SQLiteConnection(string connectionString)
			: this()
		{
		}

		public SQLiteConnection(IntPtr db)
			: this()
		{
		}

		public new SQLiteTransaction BeginTransaction()
		{
			return null;
		}

		protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
		{
			return null;
		}

		public override void Close()
		{
		}

		public override void ChangeDatabase(string databaseName)
		{
		}

		public override void Open()
		{
		}

		public override string ConnectionString { get; set; }

		public override string Database
		{
			get { return null; }
		}

		public override ConnectionState State
		{
			get { return default(ConnectionState); }
		}

		public override string DataSource
		{
			get { return null; }
		}

		public override string ServerVersion
		{
			get { return null; }
		}

		protected override DbCommand CreateDbCommand()
		{
			return null;
		}

//		public override DataTable GetSchema()
//		{
//			return null;
//		}
//
//		public override DataTable GetSchema(string collectionName)
//		{
//			return null;
//		}
//
//		public override DataTable GetSchema(string collectionName, string[] restrictionValues)
//		{
//			return null;
//		}
//
//		public override Task OpenAsync(CancellationToken cancellationToken)
//		{
//			return null;
//		}

		public override int ConnectionTimeout
		{
			get { throw new NotSupportedException(); }
		}

		protected override DbProviderFactory DbProviderFactory
		{
			get { throw new NotSupportedException(); }
		}

		protected override void Dispose(bool disposing)
		{
		}

//		protected override object GetService(Type service)
//		{
//			return null;
//		}
//
//		protected override bool CanRaiseEvents
//		{
//			get { return false; }
//		}
	}
}
