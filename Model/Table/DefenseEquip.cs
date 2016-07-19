using Model.Base;
using Model.Util;

namespace Model.Table
{
    /// <summary>
    /// 防具
    /// </summary>
    /// <remarks>防具</remarks>
    [DataTable("防具")]
    public class DefenseEquip : Equip
    {
        /// <summary>
        /// 利刃
        /// </summary>
        /// <remarks>利刃</remarks>
        private int _edge;
        /// <summary>
        /// 钝器
        /// </summary>
        /// <remarks>钝器</remarks>
        private int _blunt;
        [DataField("利刃")]
        public int Edge
        {
            get
            {
                return _edge;
            }

            set
            {
                _edge = value;
            }
        }
        [DataField("钝器")]
        public int Blunt
        {
            get
            {
                return _blunt;
            }

            set
            {
                _blunt = value;
            }
        }
    }
}
