using Model.Util;

namespace Model.Table
{
    [DataTable("物品关系")]
    public class ArticleRelation
    {
        private byte _id;

        private byte _article_ti;

        private string _article_tn;

        private int _count;

        private byte _talbe_ti;

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
        [DataField("物品")]
        public byte Article_ti
        {
            get
            {
                return _article_ti;
            }

            set
            {
                _article_ti = value;
            }
        }

        public string Article_tn
        {
            get
            {
                return _article_tn;
            }

            set
            {
                _article_tn = value;
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
        [DataField("存在位置")]
        public byte Talbe_ti
        {
            get
            {
                return _talbe_ti;
            }

            set
            {
                _talbe_ti = value;
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
