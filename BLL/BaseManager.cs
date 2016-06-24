using System;
using DAL.Base;
using Model.Util;
using Model.Table;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BLL
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    public class BaseManager
    {
        Dictionary<string, object> tableList = new Dictionary<string, object>();

        readonly string MODEL_NAMESPACE = "Model";

        readonly string MODEL_TABLE_NAMESPACE = "Model.Table";

        public BaseManager()
        {
            foreach (Type t in Assembly.Load(MODEL_NAMESPACE).GetTypes())
            {
                if (t.FullName.Contains(MODEL_TABLE_NAMESPACE))
                {
                    tableList.Add(t.Name, Assembly.Load(MODEL_NAMESPACE).CreateInstance(t.FullName, false));
                }
            }
            ExistTableObjects();
        }
        /// <summary>
        /// 查询数据库表列表
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> FindTableObjects()
        {
            Dictionary<string, string> tableMap = new Dictionary<string, string>();
            foreach (var item in tableList)
            {
                string tableName = ((DataTableAttribute)Attribute.GetCustomAttribute(item.Value.GetType(), typeof(DataTableAttribute))).TableName;
                tableMap.Add(tableName, item.Key);
            }
            return tableMap;
        }
        /// <summary>
        /// 检查数据库表是否存在，不存在创建新表
        /// </summary>
        public void ExistTableObjects()
        {
            ArrayList list = new ArrayList();
            List<string> tableNameList = SetupBase.ExistsTableObjects();
            foreach (var item in tableList)
            {
                if (!tableNameList.Contains(item.Key))
                {
                    list.Add(item.Value);
                }
            }
            if (list.Count > 0)
            {
                SetupBase.CreateTableObjects(list);
            }
        }
        /// <summary>
        /// 查询指定数据库表的字段名
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public Dictionary<string, string> FindTableTitle(string tableName)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            PropertyInfo[] propertys = tableList[tableName].GetType().GetProperties();
            foreach(PropertyInfo property in propertys)
            {
                var a = (DataFieldAttribute)Attribute.GetCustomAttribute(property, typeof(DataFieldAttribute));
                list.Add(property.Name, a.Name);
            }
            return list;
        }
        /// <summary>
        /// 查询指定数据库表的数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<List<string>> FindTableObjects(string tableName)
        {
            List<List<string>> list = new List<List<string>>();
            List<object> data = SetupBase.SelectTableObjects(tableList[tableName]);
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
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="tableObjects"></param>
        /// <param name="tableName"></param>
        public void AddTableObjects(Dictionary<string, string> tableObjects, string tableName)
        {
            ArrayList list = new ArrayList();
            var v = this.tableList[tableName];
            PropertyInfo[] propertys = v.GetType().GetProperties();
            foreach(PropertyInfo property in propertys)
            {
                if (!tableObjects.ContainsKey("Id") && property.Name.Equals("Id"))
                {
                    continue;
                }
                property.SetValue(v, Convert.ChangeType(tableObjects[property.Name], property.PropertyType));
            }
            list.Add(v);
            if (tableObjects.ContainsKey("Id"))
            {
                SetupBase.UpdateTableObjects(list);
            }
            else
            {
                SetupBase.AddTableObjects(list);
            }
        }
        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetTableObjects(string id, string tableName)
        {
            return SetupBase.GetTableObjectsById(id, tableList[tableName]);
        }
        /// <summary>
        /// 根据ID删除表数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        public void DelTableObjects(string id, string tableName)
        {
            SetupBase.DeleteTableObjects(id, tableName);
        }
        /// <summary>
        /// 查询名称
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public Dictionary<string, string> FindTableName(string tableName)
        {
            return SetupBase.FindTableName(tableList[tableName]);
        }
    }
}
