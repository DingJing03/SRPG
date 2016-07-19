using Model.Base;
using Model.Util;
using Model.Enum;

namespace Model.Table
{
    /// <summary>
    /// 房屋
    /// </summary>
    [DataTable("房屋")]
    public class House : Cell
    {
        /// <summary>
        /// 类型
        /// </summary>
        private HouseType _type;
        [DataField("类型")]
        public HouseType Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
    }
}
