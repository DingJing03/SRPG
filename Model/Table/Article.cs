using Model.Base;
using Model.Util;

namespace Model.Table
{
    /// <summary>
    /// 物品
    /// </summary>
    /// <remarks>物品</remarks>
    public class Article : Cell
    {
        /// <summary>
        /// 重量
        /// </summary>
        /// <remarks>重量</remarks>
        private int _weight;

        
        [DataField("重量")]
        public int Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }
    }
}
