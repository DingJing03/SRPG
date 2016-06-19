using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    public class Game
    {
        /// <summary>
        /// 说明
        /// </summary>
        public Explain explain;

        /// <param name="name">名称</param>
        public Game(string name)
        {
            explain.name = name;
        }

        /// <summary>
        /// 进入
        /// </summary>
        public string into(string roleName)
        {
            return roleName;
        }
    }
}