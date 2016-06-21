using Model.Util;

namespace Model.Util
{
    [DataTable("role")]
    public class Role : Biont
    {
        private byte id;
        [DataField("id", 3,AllowNull = false,PrimaryKey = false,Identity = false)]
        public byte Id
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
