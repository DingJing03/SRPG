using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
            Game game = new Game("游戏");
            Console.WriteLine("欢迎来到"+game.explain.name + "\n\n请输入角色名称：");
            string roleName = Console.ReadLine();
            Console.WriteLine("创建角色：" + game.into(roleName));
            Console.ReadKey();
        }

        public void Start()
        {
            //创建数据库名称为xuanyusong.db
            DbAccess db = new DbAccess("data source=xuanyusong.db");
            //创建数据库表，与字段
            db.CreateTable("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "text", "text", "text", "text" });
            //关闭对象
            db.CloseSqlConnection();
            Console.WriteLine("创建数据库");
        }

    }
}
