using System.Data.Common;

namespace System.Data.SQLite
{
	public sealed class SQLiteException : DbException
	{
		public SQLiteException(SQLiteErrorCode errorCode)
			: base(null, (int)errorCode)
		{
		}
	}
}
