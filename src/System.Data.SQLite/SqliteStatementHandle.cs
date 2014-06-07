using Microsoft.Win32.SafeHandles;

namespace System.Data.SQLite
{
	internal sealed class SqliteStatementHandle
#if NET45
		: CriticalHandleZeroOrMinusOneIsInvalid
#else
		: SafeHandleZeroOrMinusOneIsInvalid
#endif
	{
		public SqliteStatementHandle()
#if !NET45
			: base(true)
#endif
		{
		}

		protected override bool ReleaseHandle()
		{
			return NativeMethods.sqlite3_finalize(handle) == SQLiteErrorCode.Ok;
		}
	}
}
