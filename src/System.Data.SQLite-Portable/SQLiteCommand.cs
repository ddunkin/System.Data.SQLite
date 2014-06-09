using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.SQLite
{
	public sealed class SQLiteCommand : DbCommand
	{
		public SQLiteCommand()
			: this(null, null, null)
		{
		}

		public SQLiteCommand(string commandText)
			: this(commandText, null, null)
		{
		}

		public SQLiteCommand(SQLiteConnection connection)
			: this(null, connection, null)
		{
		}

		public SQLiteCommand(string commandText, SQLiteConnection connection)
			: this(commandText, connection, null)
		{
		}

		public SQLiteCommand(string commandText, SQLiteConnection connection, SQLiteTransaction transaction)
		{
		}

		public override void Prepare()
		{
		}

		public override string CommandText { get; set; }

		public override int CommandTimeout { get; set; }

		public override CommandType CommandType
		{
			get
			{
				return default(CommandType);
			}
			set
			{
			}
		}

		public override UpdateRowSource UpdatedRowSource
		{
			get { return default(UpdateRowSource); }
			set { }
		}

		protected override DbConnection DbConnection { get; set; }

		public new SQLiteParameterCollection Parameters
		{
			get
			{
				return null;
			}
		}

		protected override DbParameterCollection DbParameterCollection
		{
			get { return null; }
		}

		protected override DbTransaction DbTransaction { get; set; }

//		public override bool DesignTimeVisible { get; set; }

		public override void Cancel()
		{
		}

		protected override DbParameter CreateDbParameter()
		{
			return null;
		}

		protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
		{
			return null;
		}

		public new SQLiteDataReader ExecuteReader()
		{
			return null;
		}

		public override int ExecuteNonQuery()
		{
			return 0;
		}

		public override object ExecuteScalar()
		{
			return null;
		}

//		public override async Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
//		{
//			return null;
//		}
//
//		protected override Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
//		{
//			return null;
//		}
//
//		public override async Task<object> ExecuteScalarAsync(CancellationToken cancellationToken)
//		{
//			return null;
//		}

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
