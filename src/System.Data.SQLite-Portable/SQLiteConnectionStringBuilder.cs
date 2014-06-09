﻿using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	public sealed class SQLiteConnectionStringBuilder : DbConnectionStringBuilder
	{
		/// <summary>
		/// Gets/Sets the cache size for the connection.
		/// </summary>
		public int CacheSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets/Sets the filename to open on the connection string.
		/// </summary>
		public string DataSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets/sets the default command timeout for newly-created commands.  This is especially useful for 
		/// commands used internally such as inside a SQLiteTransaction, where setting the timeout is not possible.
		/// </summary>
		public int DefaultTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>
		/// If enabled, use foreign key constraints
		/// </summary>
		public bool ForeignKeys
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		/// If set to true, will throw an exception if the database specified in the connection
		/// string does not exist.  If false, the database will be created automatically.
		/// </summary>
		public bool FailIfMissing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		/// Determines how SQLite handles the transaction journal file.
		/// </summary>
		public SQLiteJournalModeEnum JournalMode
		{
			get
			{
				return default(SQLiteJournalModeEnum);
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets/Sets the page size for the connection.
		/// </summary>
		public int PageSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets/sets the database encryption password
		/// </summary>
		public string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>
		/// When enabled, the database will be opened for read-only access and writing will be disabled.
		/// </summary>
		public bool ReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets/Sets the synchronization mode (file flushing) of the connection string.  Default is "Normal".
		/// </summary>
		public SynchronizationModes SyncMode
		{
			get
			{
				return default(SynchronizationModes);
			}
			set
			{
			}
		}
	}

	/// <summary>
	/// This enum determines how SQLite treats its journal file.
	/// </summary>
	/// <remarks>
	/// By default SQLite will create and delete the journal file when needed during a transaction.
	/// However, for some computers running certain filesystem monitoring tools, the rapid
	/// creation and deletion of the journal file can cause those programs to fail, or to interfere with SQLite.
	///
	/// If a program or virus scanner is interfering with SQLite's journal file, you may receive errors like "unable to open database file"
	/// when starting a transaction.  If this is happening, you may want to change the default journal mode to Persist.
	/// </remarks>
	public enum SQLiteJournalModeEnum
	{
		/// <summary>
		/// The default mode, this causes SQLite to use the existing journaling mode for the database.
		/// </summary>
		Default = -1,

		/// <summary>
		/// SQLite will create and destroy the journal file as-needed.
		/// </summary>
		Delete = 0,

		/// <summary>
		/// When this is set, SQLite will keep the journal file even after a transaction has completed.  It's contents will be erased,
		/// and the journal re-used as often as needed.  If it is deleted, it will be recreated the next time it is needed.
		/// </summary>
		Persist = 1,

		/// <summary>
		/// This option disables the rollback journal entirely.  Interrupted transactions or a program crash can cause database
		/// corruption in this mode!
		/// </summary>
		Off = 2,

		/// <summary>
		/// SQLite will truncate the journal file to zero-length instead of deleting it.
		/// </summary>
		Truncate = 3,

		/// <summary>
		/// SQLite will store the journal in volatile RAM.  This saves disk I/O but at the expense of database safety and integrity.
		/// If the application using SQLite crashes in the middle of a transaction when the MEMORY journaling mode is set, then the
		/// database file will very likely go corrupt.
		/// </summary>
		Memory = 4,

		/// <summary>
		/// SQLite uses a write-ahead log instead of a rollback journal to implement transactions.  The WAL journaling mode is persistent;
		/// after being set it stays in effect across multiple database connections and after closing and reopening the database. A database
		/// in WAL journaling mode can only be accessed by SQLite version 3.7.0 or later.
		/// </summary>
		Wal = 5
	}

	/// <summary>
	/// Possible values for the "synchronous" database setting.  This setting determines
	/// how often the database engine calls the xSync method of the VFS.
	/// </summary>
	public enum SynchronizationModes
	{
		/// <summary>
		/// The database engine continues without syncing as soon as it has handed
		/// data off to the operating system.  If the application running SQLite
		/// crashes, the data will be safe, but the database might become corrupted
		/// if the operating system crashes or the computer loses power before that
		/// data has been written to the disk surface.
		/// </summary>
		Off = 0,

		/// <summary>
		/// The database engine will still sync at the most critical moments, but
		/// less often than in FULL mode.  There is a very small (though non-zero)
		/// chance that a power failure at just the wrong time could corrupt the
		/// database in NORMAL mode.
		/// </summary>
		Normal = 1,

		/// <summary>
		/// The database engine will use the xSync method of the VFS to ensure that
		/// all content is safely written to the disk surface prior to continuing.
		/// This ensures that an operating system crash or power failure will not
		/// corrupt the database.  FULL synchronous is very safe, but it is also
		/// slower.
		/// </summary>
		Full = 2
	}
}
