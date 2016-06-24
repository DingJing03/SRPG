using System.Collections.Generic;
using BLL;

namespace Windows
{
    public class ShowDataUtil
    {
        BaseManager manager;

        public ShowDataUtil()
        {
            manager = new BaseManager();
        }

        public Dictionary<string, string> ShowTableObjects()
        {
            return manager.FindTableObjects();
        }

        public Dictionary<string, string> FindTableTitle(string tableName)
        {
            return manager.FindTableTitle(tableName);
        }

        public List<List<string>> FindTableObjects(string tableName)
        {
            return manager.FindTableObjects(tableName);
        }

        public void AddTableObjects(Dictionary<string, string> tableObjects, string tableName)
        {
            manager.AddTableObjects(tableObjects, tableName);
        }

        public Dictionary<string, string> GetTableObjects(string id, string tableName)
        {
            return manager.GetTableObjects(id, tableName);
        }

        public void DelTableObjects(string id, string tableName)
        {
            manager.DelTableObjects(id, tableName);
        }

        public Dictionary<string, string> FindTableName(string tableName)
        {
            return manager.FindTableName(tableName);
        }

    }
}
