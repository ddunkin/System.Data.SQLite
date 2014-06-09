using System.Collections;
using System.Collections.Generic;
using System.Data.Common;

namespace System.Data.SQLite
{
	public sealed class SQLiteParameterCollection : DbParameterCollection
	{
		public SQLiteParameter Add(string parameterName, DbType dbType)
		{
			return null;
		}

		public override int Add(object value)
		{
			return 0;
		}

		public override void AddRange(Array values)
		{
		}

		public override bool Contains(object value)
		{
			return false;
		}

		public override bool Contains(string value)
		{
			return false;
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override void Clear()
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		protected override DbParameter GetParameter(int index)
		{
			return null;
		}

		protected override DbParameter GetParameter(string parameterName)
		{
			return null;
		}

		public override int IndexOf(object value)
		{
			return 0;
		}

		public override int IndexOf(string parameterName)
		{
			return 0;
		}

		public override void Insert(int index, object value)
		{
		}

		public override void Remove(object value)
		{
		}

		public override void RemoveAt(int index)
		{
		}

		public override void RemoveAt(string parameterName)
		{
		}

		protected override void SetParameter(int index, DbParameter value)
		{
		}

		protected override void SetParameter(string parameterName, DbParameter value)
		{
		}

		public override int Count
		{
			get { return 0; }
		}

		public override bool IsFixedSize
		{
			get { return false; }
		}

		public override bool IsReadOnly
		{
			get { return false; }
		}

		public override bool IsSynchronized
		{
			get { return false; }
		}

		public override object SyncRoot
		{
			get { return null; }
		}

		public new SQLiteParameter this[int index]
		{
			get { return null; }
			set { }
		}
	}
}
