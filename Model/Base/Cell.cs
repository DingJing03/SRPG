using Model.Util;

namespace Model.Base
{
    public class Cell
    {
        /// <remarks>说明</remarks>
        public string intro;

        /// <remarks>名称</remarks>
        public string name;

        /// <remarks>质量</remarks>
        public double mass;

        [DataField("简介")]
        public string Intro
        {
            get
            {
                return intro;
            }

            set
            {
                intro = value;
            }
        }

        [DataField("名称")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        [DataField("质量")]
        public double Mass
        {
            get
            {
                return mass;
            }

            set
            {
                mass = value;
            }
        }
    }
}
