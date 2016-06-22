using Model.Base;

namespace Model.Base
{
    [DataTable("role")]
    public class Role : Biont
    {
        //id	atk	def	hp	max_hp	vp	max_vp	name	

        private byte id;

        public Role()
        {

        }
        public Role(string name, double atk, double def, double hp, double maxHp, double vp, double maxVp) : base(name, atk, def, hp, maxHp, vp, maxVp)
        {
            
        }

        [DataField("id")]
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
