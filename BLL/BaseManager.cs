using System;
using DAL.Base;
using Model.Util;
using Model.Table;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;

namespace BLL
{
    public class BaseManager
    {
        Dictionary<string, object> tableObjects = new Dictionary<string, object>();

        readonly string MODEL_NAMESPACE = "Model";

        readonly string MODEL_TABLE_NAMESPACE = "Model.Table";

        public BaseManager()
        {
            foreach (Type t in Assembly.Load(MODEL_NAMESPACE).GetTypes())
            {
                if (t.FullName.Contains(MODEL_TABLE_NAMESPACE))
                {
                    tableObjects.Add(t.Name, Assembly.Load(MODEL_NAMESPACE).CreateInstance(t.FullName, false));
                }
            }
            ExistTableObjects();
        }

        public Dictionary<string, string> FindTableObjects()
        {
            Dictionary<string, string> tableMap = new Dictionary<string, string>();
            foreach (var item in tableObjects)
            {
                string tableName = ((DataTableAttribute)Attribute.GetCustomAttribute(item.Value.GetType(), typeof(DataTableAttribute))).TableName;
                tableMap.Add(tableName, item.Key);
            }
            return tableMap;
        }
        
        public void ExistTableObjects()
        {
            ArrayList list = new ArrayList();
            //foreach (var item in tableObjects)
            //{
            //    if (!SetupBase.ExistsTableObjects(item.Value))
            //    {
            //        list.Add(item.Value);
            //        Debug.WriteLine(item.Key, "CreateTable");
            //    }
            //}
            if (list.Count > 0)
            {
                SetupBase.CreateTableObjects(list);
            }
        }

        public Dictionary<string, string> FindTableTitle(string tableName)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            PropertyInfo[] propertys = tableObjects[tableName].GetType().GetProperties();
            foreach(PropertyInfo property in propertys)
            {
                list.Add(property.Name, ((DataFieldAttribute)Attribute.GetCustomAttribute(property, typeof(DataFieldAttribute))).Name);
            }
            return list;
        }

        public List<List<string>> FindTableObjects(string tableName)
        {
            List<List<string>> list = new List<List<string>>();
            List<object> data = SetupBase.SelectTableObjects(tableObjects[tableName]);
            foreach(object o in data)
            {
                List<string> items = new List<string>();
                PropertyInfo[] propertys = o.GetType().GetProperties();
                foreach(PropertyInfo property in propertys)
                {
                    items.Add(property.GetValue(o, null).ToString());
                }
                list.Add(items);
            }
            return list;
        }
    }
}
