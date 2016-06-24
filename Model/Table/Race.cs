using Model.Util;
using Model.Base;

namespace Model.Table
{
    [DataTable("种族")]
    class Race : Biont
    {
        private int id;
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
    }
}
