using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// 细胞
    /// </summary>
    public abstract class Cell
    {
        /// <summary>
        /// 质量
        /// </summary>
        public double mass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// 说明
        /// </summary>
        public Explain explain
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
