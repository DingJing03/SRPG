using System;
using DAL.Base;
using Mono.Data.Sqlite;
using Model.Table;
using System.Collections;

namespace DAL
{
    public class BaseManager
    {

        public static void CreateTalbe()
        {
            ArrayList list = new ArrayList();
            //list.Add(new Role("角色", 1, 1, 10, 10, 10, 10));
            //list.Add(new Role("角色1", 2, 1, 10, 10, 10, 10));
            //list.Add(new Role("角色2", 2, 2, 10, 10, 10, 10));
            //list.Add(new Role("角色2", 2, 2, 10, 20, 10, 10));
            //SetupBase.AddTableObjects(list);
            SetupBase.SelectTableObjects(new Role());
        }

        public void SelectTalbe()
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=xuanyusong.db");
            //请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
            db.InsertInto("role", new string[] { "'宣雨松'", "'289187120'", "'xuanyusong@gmail.com'", "'www.xuanyusong.com'" });
            db.CloseSqlConnection();
            Console.WriteLine("插入数据");
        }

        public void start()
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=frank.db");
            //创建数据库表，与字段
            db.CreateTable("momo", new string[] { "frist", "qq", "email", "blog" });
            //关闭对象
            db.CloseSqlConnection();
            Console.WriteLine("创建数据库");
        }

        public void add()
        {

            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=xuanyusong.db");
            //请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
            db.InsertInto("momo", new string[] { "'宣雨松'", "'289187120'", "'xuanyusong@gmail.com'", "'www.xuanyusong.com'" });
            db.CloseSqlConnection();
            Console.WriteLine("插入数据");
        }
        public void updae()
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=xuanyusong.db");
            db.UpdateInto("momo", new string[] { "name", "qq" }, new string[] { "'xuanyusong'", "'11111111'" }, "email", "'xuanyusong@gmail.com'");
            db.CloseSqlConnection();
            Console.WriteLine("更新数据");
        }
        public void del()
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=xuanyusong.db");
            //请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
            //db.CreateTable("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "text", "text", "text", "text" });
            //我在数据库中连续插入三条数据
            db.InsertInto("momo", new string[] { "'宣雨松'", "'289187120'", "'xuanyusong@gmail.com'", "'www.xuanyusong.com'" });
            db.InsertInto("momo", new string[] { "'雨松MOMO'", "'289187120'", "'000@gmail.com'", "'www.xuanyusong.com'" });
            db.InsertInto("momo", new string[] { "'哇咔咔'", "'289187120'", "'111@gmail.com'", "'www.xuanyusong.com'" });
            //然后在删掉两条数据
            db.Delete("momo", new string[] { "email", "email" }, new string[] { "'xuanyusong@gmail.com'", "'000@gmail.com'" });
            db.CloseSqlConnection();
            Console.WriteLine("删除数据");
        }
        public void select()
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=xuanyusong.db");
            //请注意 插入字符串是 已经要加上'宣雨松' 不然会报错
            //db.CreateTable("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "text", "text", "text", "text" });
            //我在数据库中连续插入三条数据
            db.InsertInto("momo", new string[] { "'宣雨松'", "'289187120'", "'xuanyusong@gmail.com'", "'www.xuanyusong.com'" });
            db.InsertInto("momo", new string[] { "'雨松MOMO'", "'289187120'", "'000@gmail.com'", "'www.xuanyusong.com'" });
            db.InsertInto("momo", new string[] { "'哇咔咔'", "'289187120'", "'111@gmail.com'", "'www.xuanyusong.com'" });
            //然后在删掉两条数据
            db.Delete("momo", new string[] { "email", "email" }, new string[] { "'xuanyusong@gmail.com'", "'000@gmail.com'" });
            //注解1
            SqliteDataReader sqReader = db.SelectWhere("momo", new string[] { "name", "email" }, new string[] { "qq" }, new string[] { "=" }, new string[] { "289187120" });

            while (sqReader.Read())
            {
                Console.WriteLine(sqReader.GetString(sqReader.GetOrdinal("name")) + sqReader.GetString(sqReader.GetOrdinal("email")));
            }
            db.CloseSqlConnection();
        }
    }
}
