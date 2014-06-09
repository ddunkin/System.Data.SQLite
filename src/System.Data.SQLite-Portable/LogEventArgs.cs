namespace System.Data.SQLite
{
	/// <summary>
	/// Event data for logging event handlers.
	/// </summary>
	public sealed class LogEventArgs : EventArgs
	{
		/// <summary>
		/// The error code.  The type of this object value should be
		/// <see cref="Int32" /> or <see cref="SQLiteErrorCode" />.
		/// </summary>
		public readonly object ErrorCode;

		/// <summary>
		/// SQL statement text as the statement first begins executing
		/// </summary>
		public readonly string Message;

		/// <summary>
		/// Extra data associated with this event, if any.
		/// </summary>
		public readonly object Data;
	}
}
