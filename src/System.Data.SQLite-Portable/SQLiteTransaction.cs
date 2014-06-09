using System.Data.Common;

namespace System.Data.SQLite
{
	public sealed class SQLiteTransaction : DbTransaction
	{
		public override void Commit()
		{
		}

		public override void Rollback()
		{
		}

		protected override DbConnection DbConnection
		{
			get
			{
				return null;
			}
		}

		public override IsolationLevel IsolationLevel
		{
			get
			{
				return default(IsolationLevel);
			}
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
