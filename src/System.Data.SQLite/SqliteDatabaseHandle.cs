using Microsoft.Win32.SafeHandles;

namespace System.Data.SQLite
{
	internal sealed class SqliteDatabaseHandle
#if !MONO
		: CriticalHandleZeroOrMinusOneIsInvalid
#else
		: SafeHandleZeroOrMinusOneIsInvalid
#endif
	{
		public SqliteDatabaseHandle()
#if MONO
			: base(true)
#endif
		{
		}

		public SqliteDatabaseHandle(IntPtr handle)
#if MONO
			: base(true)
#endif
		{
			SetHandle(handle);
		}

		protected override bool ReleaseHandle()
		{
#if !MONO
			return NativeMethods.sqlite3_close_v2(handle) == SQLiteErrorCode.Ok;
#else
			return NativeMethods.sqlite3_close(handle) == SQLiteErrorCode.Ok;
#endif
		}
	}
}
