using System;
using BLL;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseManager manager = new BaseManager();
            Dictionary<string, string> tableMap =  manager.FindTableObjects();
            foreach(var item in tableMap)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.ReadKey();
        }

    }
}
