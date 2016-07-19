using Model.Util;
using Model.Base;

using Model.Enum;

namespace Model.Table
{
    [DataTable("场景")]
    public class Scene : Nature
    {
        /// <summary>
        /// 探索度
        /// </summary>
        /// <remarks>探索度</remarks>
        private int _explore;
        /// <summary>
        /// 地形
        /// </summary>
        /// <remarks>地形</remarks>
        private Terrain _terrain;
        /// <summary>
        /// 探索度
        /// </summary>
        [DataField("探索度")]
        public int Explore
        {
            get
            {
                return _explore;
            }

            set
            {
                _explore = value;
            }
        }

        /// <summary>
        /// 地形
        /// </summary>
        [DataField("地形")]
        public Terrain Terrain
        {
            get
            {
                return _terrain;
            }

            set
            {
                _terrain = value;
            }
        }
    }
}
