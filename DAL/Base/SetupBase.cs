using System;
using System.Collections;
using System.Reflection;
using Model.Table;
using System.Diagnostics;
using Mono.Data.Sqlite;

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
            foreach(Object o in tableObjects)
            {
                var a = (DataTableAttribute)o.GetType().GetCustomAttributes(false)[0];
                string tableName = a.TableName;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string[] field = new string[propertys.Length];
                for (int i = 0; i < propertys.Length; i++)
                {
                    if (!propertys[i].IsDefined(typeof(DataFieldAttribute), false))
                        continue;
                    var attribute = (DataFieldAttribute)propertys[i].GetCustomAttributes(false)[0];
                    string name = string.Empty;
                    name = attribute.GetType().GetProperty("Name").GetValue(attribute).ToString();
                    if (name.Equals("id"))
                    {
                        name += " integer PRIMARY KEY autoincrement";
                    }
                    field[i] = name;
                }
                //创建数据库名称为frank.db
                DbAccess db = new DbAccess("data source=data.db");
                //创建数据库表，与字段
                db.CreateTable(tableName, field);
                //关闭对象
                db.CloseSqlConnection();
                Console.WriteLine("创建数据表：" + tableName);
            }
        }

        public static void AddTableObjects(ArrayList tableObjects)
        {
            foreach (Object o in tableObjects)
            {
                var a = (DataTableAttribute)o.GetType().GetCustomAttributes(false)[0];
                string tableName = a.TableName;
                PropertyInfo[] propertys = o.GetType().GetProperties();
                string[] field = new string[propertys.Length];
                for (int i = 0; i < propertys.Length; i++)
                {
                    if (!propertys[i].IsDefined(typeof(DataFieldAttribute), false))
                        continue;
                    var value = propertys[i].GetValue(o, null);
                    var attribute = (DataFieldAttribute)propertys[i].GetCustomAttributes(false)[0];
                    string name = attribute.GetType().GetProperty("Name").GetValue(attribute).ToString();
                    if (name.Equals("id"))
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
                //创建数据库名称为xuanyusong.db
                DbAccess db = new DbAccess("data source=data.db");
                //请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
                db.InsertInto(tableName, field);
                db.CloseSqlConnection();
                Console.WriteLine("插入数据表：" + tableName);
            }
        }
        public static void SelectTableObjects(Object o)
        {
            var a = (DataTableAttribute)o.GetType().GetCustomAttributes(false)[0];
            string tableName = a.TableName;
            PropertyInfo[] propertys = o.GetType().GetProperties();
            string[] field = new string[propertys.Length];
            for (int i = 0; i < propertys.Length; i++)
            {
                if (!propertys[i].IsDefined(typeof(DataFieldAttribute), false))
                    continue;
                var value = propertys[i].GetValue(o, null);
                var attribute = (DataFieldAttribute)propertys[i].GetCustomAttributes(false)[0];
                field[i] = attribute.GetType().GetProperty("Name").GetValue(attribute).ToString();
                
            }
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=data.db");
            //注解1
            SqliteDataReader sqReader = db.SelectWhere(tableName, field, null, null, null);
            string strTitle = string.Empty;
            foreach (string s in field)
            {
                strTitle += s + "\t";
            }
            Console.WriteLine(strTitle);
            while (sqReader.Read())
            {
                string str = string.Empty;
                foreach(string s in field)
                {
                    str += sqReader[s] + "\t";
                }
                Console.WriteLine(str);
            }
            db.CloseSqlConnection();
        }
    }
    
}
