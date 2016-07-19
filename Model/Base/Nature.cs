using Model.Util;

namespace Model.Base
{
    /// <summary>
    /// 坐标
    /// </summary>
    public class Nature : Cell
    {
        /// <summary>
        /// 坐标x轴
        /// </summary>
        /// <remarks>x轴</remarks>
        private int _x;
        /// <summary>
        /// 坐标x轴
        /// </summary>
        /// <remarks>y轴</remarks>
        private int _y;
        /// <summary>
        /// 坐标x轴
        /// </summary>
        /// <remarks>z轴</remarks>
        private int _z;
        [DataField("x轴")]
        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }
        [DataField("y轴")]
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
        [DataField("z轴")]
        public int Z
        {
            get
            {
                return _z;
            }

            set
            {
                _z = value;
            }
        }
    }
}
