using Model.Util;

namespace Model.Base
{
    public class Cell
    {
        private byte _id;
        /// <remarks>说明</remarks>
        private string _intro;
        /// <remarks>名称</remarks>
        private string _name;

        [DataField("简介")]
        public string Intro
        {
            get
            {
                return _intro;
            }

            set
            {
                _intro = value;
            }
        }
        [DataField("名称")]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        [DataField("ID")]
        public byte Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
    }
}
