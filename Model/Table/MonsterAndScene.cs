using Model.Util;

namespace Model.Table
{
    [DataTable("怪物和场景")]
    public class MonsterAndScene
    {

        private int id;

        private int monster_Id;

        private int scene_Id;

        private int count;
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
        [DataField("怪物")]
        public int Monster_Id
        {
            get
            {
                return monster_Id;
            }

            set
            {
                monster_Id = value;
            }
        }
        [DataField("场景")]
        public int Scene_Id
        {
            get
            {
                return scene_Id;
            }

            set
            {
                scene_Id = value;
            }
        }
        [DataField("怪物数量")]
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
    }
}
