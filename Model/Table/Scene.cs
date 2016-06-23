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

        public Scene(string name, string infro) : base(name, infro)
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
