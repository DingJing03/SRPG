using Model.Util;

namespace Model.Base
{
    /// <remarks>生物</remarks>
    public class Biont : Cell
    {
        /// <summary>
        /// 力量
        /// </summary>
        /// <remarks>力量</remarks>
        private int _strength;
        /// <summary>
        /// 当前体质
        /// </summary>
        /// <remarks>当前体质</remarks>
        private int _currentHabitus;
        /// <summary>
        /// 最大体质
        /// </summary>
        /// <remarks>最大体质</remarks>
        private int _maxHabitus;
        /// <summary>
        /// 理论体质
        /// </summary>
        /// <remarks>理论体质</remarks>
        private int _theoryHabitus;
        /// <summary>
        /// 当前耐力
        /// </summary>
        /// <remarks>当前耐力</remarks>
        private int _currentStamina;
        /// <summary>
        /// 最大耐力
        /// </summary>
        /// <remarks>最大耐力</remarks>
        private int _maxStamina;
        /// <summary>
        /// 理论耐力
        /// </summary>
        /// <remarks>理论耐力</remarks>
        private int _theoryStamina;
        /// <summary>
        /// 当前负重
        /// </summary>
        /// <remarks>当前负重</remarks>
        private int _currentLoad;
        /// <summary>
        /// 最大负重
        /// </summary>
        /// <remarks>最大负重</remarks>
        private int _maxLoad;
        /// <summary>
        /// 当前饱食度
        /// </summary>
        /// <remarks>当前饱食度</remarks>
        private int _currentEatDegree;
        /// <summary>
        /// 最大饱食度
        /// </summary>
        /// <remarks>最大饱食度</remarks>
        private int _maxEatDegree;
        /// <summary>
        /// 感知
        /// </summary>
        /// <remarks>感知</remarks>
        private int _perception;
        /// <summary>
        /// 敏捷
        /// </summary>
        /// <remarks>敏捷</remarks>
        private int _agility;
        /// <summary>
        /// 速度
        /// </summary>
        /// <remarks>速度</remarks>
        private int _speed;
        /// <summary>
        /// 命中
        /// </summary>
        /// <remarks>命中</remarks>
        private int _hit;
        /// <summary>
        /// 闪避
        /// </summary>
        /// <remarks>闪避</remarks>
        private int _sidestep;
        /// <summary>
        /// 力量
        /// </summary>
        [DataField("力量")]
        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                _strength = value;
            }
        }
        /// <summary>
        /// 当前体质
        /// </summary>
        [DataField("当前体质")]
        public int CurrentHabitus
        {
            get
            {
                return _currentHabitus;
            }

            set
            {
                _currentHabitus = value;
            }
        }
        /// <summary>
        /// 最大体质
        /// </summary>
        [DataField("最大体质")]
        public int MaxHabitus
        {
            get
            {
                return _maxHabitus;
            }

            set
            {
                _maxHabitus = value;
            }
        }
        /// <summary>
        /// 理论体质
        /// </summary>
        [DataField("理论体质")]
        public int TheoryHabitus
        {
            get
            {
                return _theoryHabitus;
            }

            set
            {
                _theoryHabitus = value;
            }
        }
        /// <summary>
        /// 当前耐力
        /// </summary>
        [DataField("当前耐力")]
        public int CurrentStamina
        {
            get
            {
                return _currentStamina;
            }

            set
            {
                _currentStamina = value;
            }
        }
        /// <summary>
        /// 最大耐力
        /// </summary>
        [DataField("最大耐力")]
        public int MaxStamina
        {
            get
            {
                return _maxStamina;
            }

            set
            {
                _maxStamina = value;
            }
        }
        /// <summary>
        /// 理论耐力
        /// </summary>
        [DataField("理论耐力")]
        public int TheoryStamina
        {
            get
            {
                return _theoryStamina;
            }

            set
            {
                _theoryStamina = value;
            }
        }
        /// <summary>
        /// 当前负重
        /// </summary>
        [DataField("当前负重")]
        public int CurrentLoad
        {
            get
            {
                return _currentLoad;
            }

            set
            {
                _currentLoad = value;
            }
        }
        /// <summary>
        /// 最大负重
        /// </summary>
        [DataField("最大负重")]
        public int MaxLoad
        {
            get
            {
                return _maxLoad;
            }

            set
            {
                _maxLoad = value;
            }
        }
        /// <summary>
        /// 当前饱食度
        /// </summary>
        [DataField("当前饱食度")]
        public int CurrentEatDegree
        {
            get
            {
                return _currentEatDegree;
            }

            set
            {
                _currentEatDegree = value;
            }
        }
        /// <summary>
        /// 最大饱食度
        /// </summary>
        [DataField("最大饱食度")]
        public int MaxEatDegree
        {
            get
            {
                return _maxEatDegree;
            }

            set
            {
                _maxEatDegree = value;
            }
        }
        /// <summary>
        /// 感知
        /// </summary>
        [DataField("感知")]
        public int Perception
        {
            get
            {
                return _perception;
            }

            set
            {
                _perception = value;
            }
        }
        /// <summary>
        /// 敏捷
        /// </summary>
        [DataField("敏捷")]
        public int Agility
        {
            get
            {
                return _agility;
            }

            set
            {
                _agility = value;
            }
        }
        /// <summary>
        /// 速度
        /// </summary>
        [DataField("速度")]
        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }
        /// <summary>
        /// 命中
        /// </summary>
        [DataField("命中")]
        public int Hit
        {
            get
            {
                return _hit;
            }

            set
            {
                _hit = value;
            }
        }
        /// <summary>
        /// 闪避
        /// </summary>
        [DataField("闪避")]
        public int Sidestep
        {
            get
            {
                return _sidestep;
            }

            set
            {
                _sidestep = value;
            }
        }
    }
}
