using System;
using DAL.Base;
using Model.Table;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace DAL
{
    public class BaseManager
    {
        Dictionary<string, object> map = new Dictionary<string, object>();

        public static void CreateTalbe()
        {
            ArrayList list = new ArrayList();
            list.Add(new Role("角色", "角色简介", 1, 1, 10, 10, 10, 10));
            //SetupBase.CreateTableObjects(list);
            list.Add(new Role("角色1", "角色简介", 2, 1, 10, 10, 10, 10));
            list.Add(new Role("角色2", "角色简介", 2, 2, 10, 10, 10, 10));
            //list.Add(new Role("角色2", 2, 2, 10, 20, 10, 10));
            //SetupBase.AddTableObjects(list);
            List<Role> roles = SetupBase.SelectTableObjects<Role>(new Role());
            Console.WriteLine(roles.Count);
        }
        
        public static string ShowTableObjects()
        {

            foreach (Type t in Assembly.Load("Model").GetTypes())
            {
                if (t.FullName.Contains("Model.Table"))
                {
                    Console.WriteLine(t.Name);
                }
            }
            return null;
        }
    }
}
