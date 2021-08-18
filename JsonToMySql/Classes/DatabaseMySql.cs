using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToMySql.Classes
{
	class DatabaseMySql
	{
		const string CONN_PATTERN = "server={0}; port={1}; database={2}; user={3}; password={4}; Persist Security Info=False;";

		string server, database, username, port;
		string connectionString;
		
		MySqlConnection conn;
		public DatabaseMySql(string server, string database, string username, string pwd, string port = "3306")
		{
			connectionString = String.Format(CONN_PATTERN, server, port, database, username, pwd);
			this.server = server;
			this.database = database;
			this.username = username;
			this.port = port;
			conn = new MySqlConnection(connectionString);
		}
		public bool OpenConnection()
		{
			try
			{
				conn.Open();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public bool CloseConnection()
		{
			try
			{
				conn.Close();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public bool TableExists(string tableName)
		{
			var query = "SELECT COUNT(*) FROM information_schema.tables"
						+ $" WHERE table_schema = '{database}'"
						+ $" AND table_name = '{tableName}'";
			MySqlCommand cmd = new MySqlCommand(query, conn);
			var count = Convert.ToInt32(cmd.ExecuteScalar());
			return count > 0;
		}

		public async Task CreateTableAsync(Type type, string tableName)
		{
			List<string> listSqlBody = new List<string>();
			// Primary key
			listSqlBody.Add("Id INT NOT NULL AUTO_INCREMENT");

			foreach (var prop in type.GetProperties())
			{
				object[] attrs = prop.GetCustomAttributes(true);
				foreach (object attr in attrs)
				{
					MySqlTypeAttribute mySqlType = attr as MySqlTypeAttribute;
					if (mySqlType != null)
					{
						string colName = prop.Name;
						string colType = mySqlType.MySqlDataType;

						listSqlBody.Add($"{colName} {colType} NOT NULL");
					}
				}
			}

			// Primary key
			listSqlBody.Add("PRIMARY KEY (Id)");
			var sqlBody = String.Join(",", listSqlBody);
			var sql = $"CREATE TABLE {tableName}({sqlBody});";

			MySqlCommand cmd = new MySqlCommand(sql, conn);
			await cmd.ExecuteNonQueryAsync();
		}

		public async Task BulkInsertAsync<T>(IEnumerable<T> data, string tableName)
		{
			var type = typeof(T);
			var cols = new List<string>();
			var sqlDataType = new List<string>();
			foreach (var prop in type.GetProperties())
			{
				object[] attrs = prop.GetCustomAttributes(true);
				foreach (object attr in attrs)
				{
					MySqlTypeAttribute mySqlType = attr as MySqlTypeAttribute;
					if (mySqlType != null)
					{
						cols.Add(prop.Name);
						sqlDataType.Add(mySqlType.MySqlDataType.ToLower());
					}
				}
			}

			var listInsert = new List<string>();
			var strCols = String.Join(",", cols);
			foreach (var item in data)
			{
				var listValue = new List<string>();
				for (int i = 0; i<cols.Count;i++)
				{
					var col = cols[i];
					var prop = type.GetProperty(col);
					var value = prop.GetValue(item).ToString() ?? "NULL";
					if (DataTypeIsNeedQuote(sqlDataType[i]))
					{
						value = $"'{value}'";
					}
					listValue.Add(value);
				}
				listInsert.Add($"INSERT INTO {tableName}({strCols}) VALUES({String.Join(",", listValue)})");
			}
			var sql = String.Join(";", listInsert);
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			await cmd.ExecuteNonQueryAsync();
		}

		public async Task DeleteAllAsync(string tableName)
		{
			var sql = $"DELETE FROM {database}.{tableName}";
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			await cmd.ExecuteNonQueryAsync();
		}

		private bool DataTypeIsNeedQuote(string type)
		{
			var checkSet = new string[]{"char", "varchar", "text", "date", "datetime", "time", "timestamp"};
			foreach (var item in checkSet)
			{
				if (type.IndexOf(item) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}
}
