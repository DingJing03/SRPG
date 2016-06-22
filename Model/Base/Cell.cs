using Model.Base;

namespace Model.Base
{
    public class Cell
    {

        private string name;

        public Cell()
        {

        }
        public Cell(string name)
        {
            this.name = name;
        }

        [DataField("name")]
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
