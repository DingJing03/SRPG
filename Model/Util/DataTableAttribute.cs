using System;

namespace Model.Table
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
    public class DataTableAttribute : Attribute
    {
        private string tableName;

        public DataTableAttribute(string tableName)
        {
            this.TableName = tableName;
        }

        public string TableName
        {
            get
            {
                return tableName;
            }

            set
            {
                tableName = value;
            }
        }
    }
}
