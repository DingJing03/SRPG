using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("游戏");
            Console.WriteLine("欢迎来到"+game.explain.name + "\n\n请输入角色名称：");
            string roleName = Console.ReadLine();
            Console.WriteLine("创建角色：" + game.into(roleName));
            Console.ReadKey();
        }
    }
}
