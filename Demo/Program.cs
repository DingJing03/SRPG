using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DAL.BaseManager p = new DAL.BaseManager();
            //p.start();
            p.add();
            p.updae();
            p.del();
            p.select();
            
            Console.ReadKey();
        }

        
    }
}
