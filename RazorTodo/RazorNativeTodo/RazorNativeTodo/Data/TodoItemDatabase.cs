using System;
//using SQLite.Net;
using System.Collections.Generic;
using System.Linq;

namespace RazorNativeTodo
{
	public class TodoItemDatabase 
	{
		static object locker = new object ();

		//SQLiteConnection database;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		/// <param name='path'>
		/// Path.
		/// </param>
		//public TodoItemDatabase(SQLiteConnection conn)
		//{
		//	database = conn;
		//	// create the tables
		//	database.CreateTable<TodoItem>();
		//}

		public IEnumerable<TodoItem> GetItems ()
		{
			//lock (locker) {
			//	return (from i in database.Table<TodoItem>() select i).ToList();
			//}

            return new List<TodoItem>();
		}

		public IEnumerable<TodoItem> GetItemsNotDone ()
		{
			//lock (locker) {
			//	return database.Query<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
			//}

            return new List<TodoItem>();
		}

		public TodoItem GetItem (int id) 
		{
			//lock (locker) {
			//	return database.Table<TodoItem>().FirstOrDefault(x => x.ID == id);
			//}

            return new TodoItem();
		}

		public int SaveItem (TodoItem item) 
		{
			//lock (locker) {
			//	if (item.ID != 0) {
			//		database.Update(item);
			//		return item.ID;
			//	} else {
			//		return database.Insert(item);
			//	}
			//}

		    return 1;
		}

		public int DeleteItem(int id)
		{
			//lock (locker) {
			//	return database.Delete<TodoItem>(id);
			//}

		    return 1;
		}
	}
}

