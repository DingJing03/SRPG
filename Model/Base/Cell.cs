using Model.Util;

namespace Model.Base
{
    public class Cell
    {
        private string intro;

        private string name;

        public Cell()
        {

        }
        public Cell(string name, string intro)
        {
            this.name = name;
            this.intro = intro;
        }
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
    }
}
