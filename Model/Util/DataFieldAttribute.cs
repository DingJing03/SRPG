using System;

namespace Model.Table
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DataFieldAttribute : Attribute
    {
        private string name;

        private int size;

        private bool allowNull;

        private bool primaryKey;

        private bool identity;

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

        public bool AllowNull
        {
            get
            {
                return allowNull;
            }

            set
            {
                allowNull = value;
            }
        }

        public bool PrimaryKey
        {
            get
            {
                return primaryKey;
            }

            set
            {
                primaryKey = value;
            }
        }

        public bool Identity
        {
            get
            {
                return identity;
            }

            set
            {
                identity = value;
            }
        }

        public DataFieldAttribute(string name, int size, bool allowNull, bool primaryKey, bool identity)
        {
            this.Name = name;
            this.Size = size;
            this.AllowNull = allowNull;
            this.PrimaryKey = primaryKey;
            this.Identity = identity;
        }

        public DataFieldAttribute(string name)
        {
            this.name = name;
        }
    }
}
