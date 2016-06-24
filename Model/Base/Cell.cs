using Model.Util;

namespace Model.Base
{
    public class Cell
    {
        private string intro;

        private string name;

        private double mass;

        public Cell()
        {

        }
        public Cell(string name, string intro, double mass)
        {
            this.name = name;
            this.intro = intro;
            this.mass = mass;
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
