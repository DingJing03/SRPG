namespace Model.Table
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
        public Biont(string name, double atk, double def, double hp, double maxHp, double vp, double maxVp) : base(name)
        {
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.maxHp = maxHp;
            this.vp = vp;
            this.maxVp = maxVp;
        }

        [DataField("atk")]
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
        [DataField("def")]
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
        [DataField("hp")]
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
        [DataField("max_hp")]
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
        [DataField("vp")]
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
        [DataField("max_vp")]
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
