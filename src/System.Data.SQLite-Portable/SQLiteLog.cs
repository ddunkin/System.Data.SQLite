namespace System.Data.SQLite
{
	public static class SQLiteLog
	{
		/// <summary>
		/// This event is raised whenever SQLite raises a logging event.
		/// Note that this should be set as one of the first things in the
		/// application.
		/// </summary>
		public static event SQLiteLogEventHandler Log
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public delegate void SQLiteLogEventHandler(object sender, LogEventArgs e);
}
