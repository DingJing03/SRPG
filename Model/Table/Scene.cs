using Model.Util;
using Model.Base;

namespace Model.Table
{
    [DataTable("场景")]
    public class Scene : Nature
    {

        private byte id;

        public Scene()
        {
            
        }

        public Scene(string name, string infro, double mass) : base(name, infro, mass)
        {

        }
        [DataField("Id")]
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
