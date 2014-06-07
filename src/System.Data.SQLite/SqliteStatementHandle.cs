using Microsoft.Win32.SafeHandles;

namespace System.Data.SQLite
{
	internal sealed class SqliteStatementHandle
#if !MONO
		: CriticalHandleZeroOrMinusOneIsInvalid
#else
		: SafeHandleZeroOrMinusOneIsInvalid
#endif
	{
		public SqliteStatementHandle()
#if MONO
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
