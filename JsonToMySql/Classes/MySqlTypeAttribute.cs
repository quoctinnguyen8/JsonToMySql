using System;

namespace JsonToMySql.Classes
{
	internal class MySqlTypeAttribute : Attribute
	{
		public string MySqlDataType { get; private set; }
		public MySqlTypeAttribute(string dataType)
		{
			MySqlDataType = dataType;
		}
	}
}