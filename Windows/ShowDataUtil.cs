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

        public Dictionary<string, string> findTableTitle(string tableName)
        {
            return manager.FindTableTitle(tableName);
        }

        public List<List<string>> FindTableObjects(string tableName)
        {
            return manager.FindTableObjects(tableName);
        }
    }
}
