using System;
using SQLite;

namespace RazorTodo
{
	public static class App
	{
		static SQLiteConnection conn;
		static TodoItemDatabase database;
		public static void SetDatabaseConnection (SQLiteConnection connection)
		{
			conn = connection;
			database = new TodoItemDatabase (conn);
		}
		public static TodoItemDatabase Database {
			get { return database; }
		}
	}
}

