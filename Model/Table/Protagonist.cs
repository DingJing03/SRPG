using Model.Util;
using Model.Base;

namespace Model.Table
{
    [DataTable("主角")]
    public class Protagonist : Biont
    {
        private int id;

        private int race_Id;
        [DataField("Id")]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        [DataField("种族")]
        public int Race_Id
        {
            get
            {
                return race_Id;
            }

            set
            {
                race_Id = value;
            }
        }
    }
}
