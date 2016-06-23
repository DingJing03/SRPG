using Model.Util;
using Model.Base;

namespace Model.Table
{
    /// <summary>
    /// 角色
    /// </summary>
    [DataTable("角色")]
    public class Role : Biont
    {

        private int id;

        public Role()
        {

        }
        public Role(string name, string intro, double atk, double def, double hp, double maxHp, double vp, double maxVp) : base(name, intro, atk, def, hp, maxHp, vp, maxVp)
        {
            
        }

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
