using Model.Base;
using Model.Util;

namespace Model.Table
{
    [DataTable("怪物")]
    public class Monster : Biont
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
