using System;

namespace Model.Util
{
    [AttributeUsage(AttributeTargets.All)]
    public class DataFieldAttribute : Attribute
    {
        private string name;

        private int size;

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

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public DataFieldAttribute(string name)
        {
            this.name = name;
        }
    }
}
