using Microsoft.Win32.SafeHandles;

namespace System.Data.SQLite
{
	internal sealed class SqliteDatabaseHandle
#if NET45
		: CriticalHandleZeroOrMinusOneIsInvalid
#else
		: SafeHandleZeroOrMinusOneIsInvalid
#endif
	{
		public SqliteDatabaseHandle()
#if !NET45
			: base(true)
#endif
		{
		}

		public SqliteDatabaseHandle(IntPtr handle)
#if !NET45
			: base(true)
#endif
		{
			SetHandle(handle);
		}

		protected override bool ReleaseHandle()
		{
#if NET45
			return NativeMethods.sqlite3_close_v2(handle) == SQLiteErrorCode.Ok;
#else
			return NativeMethods.sqlite3_close(handle) == SQLiteErrorCode.Ok;
#endif
		}
	}
}
