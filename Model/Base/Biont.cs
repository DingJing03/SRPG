using Model.Util;

namespace Model.Base
{
    public class Biont : Cell
    {
        private double atk;

        private double def;

        private double hp;

        private double maxHp;

        private double vp;

        private double maxVp;

        public Biont()
        {

        }
        public Biont(string name, string intro, double mass, double atk, double def, double hp, double maxHp, double vp, double maxVp) : base(name, intro, mass)
        {
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.maxHp = maxHp;
            this.vp = vp;
            this.maxVp = maxVp;
        }

        [DataField("攻击")]
        public double Atk
        {
            get
            {
                return atk;
            }

            set
            {
                atk = value;
            }
        }
        [DataField("防御")]
        public double Def
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }
        [DataField("生命值")]
        public double Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }
        [DataField("最大生命值")]
        public double MaxHp
        {
            get
            {
                return maxHp;
            }

            set
            {
                maxHp = value;
            }
        }
        [DataField("体力值")]
        public double Vp
        {
            get
            {
                return vp;
            }

            set
            {
                vp = value;
            }
        }
        [DataField("最大体力值")]
        public double MaxVp
        {
            get
            {
                return maxVp;
            }

            set
            {
                maxVp = value;
            }
        }
    }
}
