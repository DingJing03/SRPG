using Model.Util;

namespace Model.Table
{
    [DataTable("制作")]
    public class Making
    {
        private byte _id;

        private byte _material_Id;

        private int _count;

        private byte _table_ti;

        private string _table_tn;
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
        [DataField("材料")]
        public byte Material_Id
        {
            get
            {
                return _material_Id;
            }

            set
            {
                _material_Id = value;
            }
        }
        [DataField("数量")]
        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }
        public byte Table_ti
        {
            get
            {
                return _table_ti;
            }

            set
            {
                _table_ti = value;
            }
        }
        public string Table_tn
        {
            get
            {
                return _table_tn;
            }

            set
            {
                _table_tn = value;
            }
        }
    }
}
