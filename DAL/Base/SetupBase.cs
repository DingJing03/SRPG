using System;
using System.Collections;
using System.Reflection;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using System.Diagnostics;

namespace DAL.Base
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public static class SetupBase
    {
        const string DB_NAME = "DataDB";

        /// <summary>
        /// 创建数据库表
        /// </summary>
        /// <param name="tableObjects">实体类集合</param>
        public static void CreateTableObjects(ArrayList tableObjects)
        {
            //创建数据库名称为frank.db
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            foreach (Object o in tableObjects)
            {
                string tableName = o.GetType().Name;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string[] field = new string[propertys.Length];
                for (int i = 0; i < propertys.Length; i++)
                {
                    string name = propertys[i].Name;
                    if (name.Equals("Id"))
                    {
                        name += " integer PRIMARY KEY autoincrement";
                    }
                    field[i] = name;
                }
                //创建数据库表，与字段
                db.CreateTable(tableName, field);
                Debug.WriteLine(tableName, "创建数据库表");
            }
            //关闭对象
            db.CloseSqlConnection();
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="tableObjects">实体数据集合</param>
        public static void AddTableObjects(ArrayList tableObjects)
        {
            //创建数据库名称为.db
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            foreach (Object o in tableObjects)
            {
                string tableName = o.GetType().Name;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string[] field = new string[propertys.Length];
                for (int i = 0; i < propertys.Length; i++)
                {
                    var value = propertys[i].GetValue(o, null);
                    string name = propertys[i].Name;
                    if (name.Equals("Id"))
                    {
                        field[i] = "null";
                    }
                    else if (value is string)
                    { 
                        field[i] = "'" + value.ToString() + "'";
                    }
                    else
                    {
                        field[i] = value.ToString();
                    }
                }
                //请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
                db.InsertInto(tableName, field);
                Debug.WriteLine(tableName, "插入数据表");
            }
            db.CloseSqlConnection();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="o">实体</param>
        /// <returns>实体集合</returns>
        public static List<object> SelectTableObjects(object o)
        {
            string tableName = o.GetType().Name;
            PropertyInfo[] propertys = o.GetType().GetProperties();
            string[] field = new string[propertys.Length];
            for (int i = 0; i < propertys.Length; i++)
            {
                field[i] = propertys[i].Name;
            }
            //创建数据库名称为.db
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            //注解1
            SqliteDataReader sqReader = db.SelectWhere(tableName, field, null, null, null);
            List<object> list = new List<object>();
            while (sqReader.Read())
            {
                o = o.GetType().Assembly.CreateInstance(o.GetType().FullName);  // 创建新的实例
                foreach (string s in field)
                {
                    PropertyInfo propertyInfo = o.GetType().GetProperty(s);
                    propertyInfo.SetValue(o, Convert.ChangeType(sqReader[s], propertyInfo.PropertyType), null);
                }
                list.Add(o);
            }
            db.CloseSqlConnection();
            return list;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="data">实体集合</param>
        public static void UpdateTableObjects(ArrayList data)
        {
            //创建数据库名称为.db
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            foreach (Object o in data)
            {
                string tableName = o.GetType().Name;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string[] field = new string[propertys.Length-1];
                string[] values = new string[propertys.Length-1];
                string id = string.Empty; int i = 0;
                foreach (PropertyInfo property in propertys)
                {
                    string value = property.GetValue(o, null).ToString();
                    if (property.Name.Equals("Id"))
                    {
                        id = value;
                        continue;
                    }
                    field[i] = property.Name;
                    if (value is string)
                    {
                        values[i] = "'" + value + "'";
                    }
                    else
                    {
                        values[i] = value;
                    }
                    i++;
                }
                db.UpdateInto(tableName, field, values, "Id", id);
            }
            db.CloseSqlConnection();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="data">根据实体集合id</param>
        public static void DeleteTableObjects(ArrayList data)
        {
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            foreach (Object o in data)
            {
                string tableName = o.GetType().Name;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string id = string.Empty;
                foreach(PropertyInfo property in propertys)
                {
                    if (property.Name.Equals("Id"))
                    {
                        id = property.GetValue(o, null).ToString();
                    }
                }
                db.Delete(tableName, new string[] { "Id" }, new string[] { id });
            }
            db.CloseSqlConnection();
        }
        public static void DeleteTableObjects(string id, string tableName)
        {
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            db.Delete(tableName, new string[] { "Id" }, new string[] { id });
            db.CloseSqlConnection();
        }
        /// <summary>
        /// 查询数据库所有表名
        /// </summary>
        /// <returns></returns>
        public static List<string> ExistsTableObjects()
        {
            List<string> list = new List<string>();
            //创建数据库名称为.db
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            SqliteDataReader sqReader = db.SelectWhere("SELECT name FROM sqlite_master where [type]='table';");
            while (sqReader.Read())
            {
                list.Add(sqReader["name"].ToString());
            }
            return list;
        }
        /// <summary>
        /// 根据ID查询表数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetTableObjectsById(string id, object o)
        {
            string tableName = o.GetType().Name;
            PropertyInfo[] propertys = o.GetType().GetProperties();
            Dictionary<string, string> tableObjects = new Dictionary<string, string>();
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            SqliteDataReader reader = db.SelectWhere(tableName, null, new string[] { "Id" }, new string[] { " = " }, new string[] { id });
            while (reader.Read())
            {
                foreach(PropertyInfo property in propertys)
                {
                    tableObjects.Add(property.Name, reader[property.Name].ToString());
                }
            }
            db.CloseSqlConnection();
            return tableObjects;
        }
        /// <summary>
        /// 查询名称
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> FindTableName(object o)
        {
            string tableName = o.GetType().Name;
            Dictionary<string, string> tableNames = new Dictionary<string, string>();
            //创建数据库名称为.db
            DbAccess db = new DbAccess("data source=" + DB_NAME + ".db");
            //注解1
            SqliteDataReader reader = db.SelectWhere(tableName, null, null, null, null);
            while (reader.Read())
            {
                tableNames.Add(reader["Name"].ToString(), reader["Id"].ToString());
            }
            db.CloseSqlConnection();
            return tableNames;
        }
    }

}
