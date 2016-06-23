using System;
using System.Collections;
using System.Reflection;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace DAL.Base
{
    public static class SetupBase
    {
        /// <summary>
        /// 创建数据库表
        /// </summary>
        /// <param name="tableObjects">实体类集合</param>
        public static void CreateTableObjects(ArrayList tableObjects)
        {
            //创建数据库名称为frank.db
            DbAccess db = new DbAccess("data source=data.db");
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
                Console.WriteLine("创建数据表：" + tableName);
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
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=data.db");
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
                Console.WriteLine("插入数据表：" + tableName);
            }
            db.CloseSqlConnection();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="o">实体</param>
        /// <returns>实体集合</returns>
        public static List<T> SelectTableObjects<T>(Object o) where T : class, new()
        {
            string tableName = o.GetType().Name;
            PropertyInfo[] propertys = o.GetType().GetProperties();
            string[] field = new string[propertys.Length];
            for (int i = 0; i < propertys.Length; i++)
            {
                field[i] = propertys[i].Name;
            }
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=data.db");
            //注解1
            SqliteDataReader sqReader = db.SelectWhere(tableName, field, null, null, null);
            List<T> list = new List<T>();
            while (sqReader.Read())
            {
                foreach (string s in field)
                {
                    PropertyInfo propertyInfo = o.GetType().GetProperty(s);
                    propertyInfo.SetValue(o, Convert.ChangeType(sqReader[s], propertyInfo.PropertyType), null);
                }
                list.Add((T)o);
            }
            db.CloseSqlConnection();
            return list;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="data">实体集合</param>
        public static void UpdateTalbeObjects(ArrayList data)
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=data.db");
            foreach (Object o in data)
            {
                string tableName = o.GetType().Name;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string[] field = new string[propertys.Length];
                string[] values = new string[propertys.Length];
                string id = string.Empty;
                for (int i = 0; i < propertys.Length; i++)
                {
                    string value = propertys[i].GetValue(o, null).ToString();
                    if (propertys[i].Name.Equals("Id"))
                    {
                        id = value;
                        continue;
                    }
                    field[i] = propertys[i].Name;
                    if (value is string)
                    {
                        values[i] = "'" + value + "'";
                    }
                    else
                    {
                        values[i] = value;
                    }
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
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=data.db");
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
    }

}
