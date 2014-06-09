using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.SQLite
{
	public sealed class SQLiteDataReader : DbDataReader
	{
		public override void Close()
		{
		}

		public override bool NextResult()
		{
			return false;
		}

//		public override Task<bool> NextResultAsync(CancellationToken cancellationToken)
//		{
//			return null;
//		}

		public override bool Read()
		{
			return false;
		}

		public override bool IsClosed
		{
			get { return false; }
		}

		public override int RecordsAffected
		{
			get { return 0; }
		}

		public override bool GetBoolean(int ordinal)
		{
			return false;
		}

		public override byte GetByte(int ordinal)
		{
			return 0;
		}

		public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			return 0;
		}

		public override char GetChar(int ordinal)
		{
			return default(char);
		}

		public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			return 0;
		}

		public override Guid GetGuid(int ordinal)
		{
			return default(Guid);
		}

		public override short GetInt16(int ordinal)
		{
			return 0;
		}

		public override int GetInt32(int ordinal)
		{
			return 0;
		}

		public override long GetInt64(int ordinal)
		{
			return 0;
		}

		public override DateTime GetDateTime(int ordinal)
		{
			return default(DateTime);
		}

		public override string GetString(int ordinal)
		{
			return null;
		}

		public override decimal GetDecimal(int ordinal)
		{
			return 0;
		}

		public override double GetDouble(int ordinal)
		{
			return 0;
		}

		public override float GetFloat(int ordinal)
		{
			return 0;
		}

		public override string GetName(int ordinal)
		{
			return null;
		}

		public override int GetValues(object[] values)
		{
			return 0;
		}

		public override bool IsDBNull(int ordinal)
		{
			return false;
		}

		public override int FieldCount
		{
			get
			{
				return 0;
			}
		}

		public override object this[int ordinal]
		{
			get { return null; }
		}

		public override object this[string name]
		{
			get { return null; }
		}

		public override bool HasRows
		{
			get
			{
				return false;
			}
		}

		public override int GetOrdinal(string name)
		{
			return 0;
		}

		public override string GetDataTypeName(int ordinal)
		{
			return null;
		}

		public override Type GetFieldType(int ordinal)
		{
			return null;
		}

		public override object GetValue(int ordinal)
		{
			return null;
		}

//		public override IEnumerator GetEnumerator()
//		{
//			return null;
//		}
//
//		public override DataTable GetSchemaTable()
//		{
//			return null;
//		}

		public override int Depth
		{
			get { return 0; }
		}

//		protected override DbDataReader GetDbDataReader(int ordinal)
//		{
//			return null;
//		}

		public override Type GetProviderSpecificFieldType(int ordinal)
		{
			return null;
		}

		public override object GetProviderSpecificValue(int ordinal)
		{
			return null;
		}

		public override int GetProviderSpecificValues(object[] values)
		{
			return 0;
		}

//		public override Task<T> GetFieldValueAsync<T>(int ordinal, CancellationToken cancellationToken)
//		{
//			return null;
//		}
//
//		public override Task<bool> IsDBNullAsync(int ordinal, CancellationToken cancellationToken)
//		{
//			return null;
//		}
//
//		public override Task<bool> ReadAsync(CancellationToken cancellationToken)
//		{
//			return null;
//		}

		public override int VisibleFieldCount
		{
			get { return FieldCount; }
		}
	}
}
