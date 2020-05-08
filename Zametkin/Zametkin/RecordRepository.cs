using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zametkin
{
    public class RecordRepository
    {
        SQLiteConnection database;
        public RecordRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Record>();
        }
        public IEnumerable<Record> GetItems()
        {
            return database.Table<Record>().ToList();
        }
        public Record GetItem(int id)
        {
            return database.Get<Record>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Record>(id);
        }
        public int SaveItem(Record item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
