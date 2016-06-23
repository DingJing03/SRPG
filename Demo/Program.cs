using System;
using System.Collections.Generic;
using Model.Util;
using System.IO;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DAL.BaseManager.ShowTableObjects();
            Console.ReadKey();
        }

    }
}
