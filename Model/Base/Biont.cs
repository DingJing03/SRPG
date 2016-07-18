using Model.Util;

namespace Model.Base
{
    public class Biont : Cell
    {
        /// <summary>
        /// 力量
        /// </summary>
        /// <remarks>力量</remarks>
        private double strength;
        /// <summary>
        /// 当前体质
        /// </summary>
        /// <remarks>当前体质</remarks>
        private double currentHabitus;
        /// <summary>
        /// 最大体质
        /// </summary>
        /// <remarks>最大体质</remarks>
        private double maxHabitus;
        /// <summary>
        /// 理论体质
        /// </summary>
        /// <remarks>理论体质</remarks>
        private double theoryHabitus;
        /// <summary>
        /// 当前耐力
        /// </summary>
        /// <remarks>当前耐力</remarks>
        private double currentStamina;
        /// <summary>
        /// 最大耐力
        /// </summary>
        /// <remarks>最大耐力</remarks>
        private double maxStamina;
        /// <summary>
        /// 理论耐力
        /// </summary>
        /// <remarks>理论耐力</remarks>
        private double theoryStamina;
        /// <summary>
        /// 当前负重
        /// </summary>
        /// <remarks>当前负重</remarks>
        private double currentLoad;
        /// <summary>
        /// 最大负重
        /// </summary>
        /// <remarks>最大负重</remarks>
        private double maxLoad;
        /// <summary>
        /// 当前饱食度
        /// </summary>
        /// <remarks>当前饱食度</remarks>
        private double currentEatDegree;
        /// <summary>
        /// 最大饱食度
        /// </summary>
        /// <remarks>最大饱食度</remarks>
        private double maxEatDegree;
        /// <summary>
        /// 感知
        /// </summary>
        /// <remarks>感知</remarks>
        private double perception;
        /// <summary>
        /// 敏捷
        /// </summary>
        /// <remarks>敏捷</remarks>
        private double agility;
        /// <summary>
        /// 速度
        /// </summary>
        /// <remarks>速度</remarks>
        private double speed;
        /// <summary>
        /// 命中
        /// </summary>
        /// <remarks>命中</remarks>
        private double hit;
        /// <summary>
        /// 闪避
        /// </summary>
        /// <remarks>闪避</remarks>
        private double sidestep;
        /// <summary>
        /// 力量
        /// </summary>
        [DataField("力量")]
        public double Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }
        /// <summary>
        /// 当前体质
        /// </summary>
        [DataField("当前体质")]
        public double CurrentHabitus
        {
            get
            {
                return currentHabitus;
            }

            set
            {
                currentHabitus = value;
            }
        }
        /// <summary>
        /// 最大体质
        /// </summary>
        [DataField("最大体质")]
        public double MaxHabitus
        {
            get
            {
                return maxHabitus;
            }

            set
            {
                maxHabitus = value;
            }
        }
        /// <summary>
        /// 理论体质
        /// </summary>
        [DataField("理论体质")]
        public double TheoryHabitus
        {
            get
            {
                return theoryHabitus;
            }

            set
            {
                theoryHabitus = value;
            }
        }
        /// <summary>
        /// 当前耐力
        /// </summary>
        [DataField("当前耐力")]
        public double CurrentStamina
        {
            get
            {
                return currentStamina;
            }

            set
            {
                currentStamina = value;
            }
        }
        /// <summary>
        /// 最大耐力
        /// </summary>
        [DataField("最大耐力")]
        public double MaxStamina
        {
            get
            {
                return maxStamina;
            }

            set
            {
                maxStamina = value;
            }
        }
        /// <summary>
        /// 理论耐力
        /// </summary>
        [DataField("理论耐力")]
        public double TheoryStamina
        {
            get
            {
                return theoryStamina;
            }

            set
            {
                theoryStamina = value;
            }
        }
        /// <summary>
        /// 当前负重
        /// </summary>
        [DataField("当前负重")]
        public double CurrentLoad
        {
            get
            {
                return currentLoad;
            }

            set
            {
                currentLoad = value;
            }
        }
        /// <summary>
        /// 最大负重
        /// </summary>
        [DataField("最大负重")]
        public double MaxLoad
        {
            get
            {
                return maxLoad;
            }

            set
            {
                maxLoad = value;
            }
        }
        /// <summary>
        /// 当前饱食度
        /// </summary>
        [DataField("当前饱食度")]
        public double CurrentEatDegree
        {
            get
            {
                return currentEatDegree;
            }

            set
            {
                currentEatDegree = value;
            }
        }
        /// <summary>
        /// 最大饱食度
        /// </summary>
        [DataField("最大饱食度")]
        public double MaxEatDegree
        {
            get
            {
                return maxEatDegree;
            }

            set
            {
                maxEatDegree = value;
            }
        }
        /// <summary>
        /// 感知
        /// </summary>
        [DataField("感知")]
        public double Perception
        {
            get
            {
                return perception;
            }

            set
            {
                perception = value;
            }
        }
        /// <summary>
        /// 敏捷
        /// </summary>
        [DataField("敏捷")]
        public double Agility
        {
            get
            {
                return agility;
            }

            set
            {
                agility = value;
            }
        }
        /// <summary>
        /// 速度
        /// </summary>
        [DataField("速度")]
        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
        /// <summary>
        /// 命中
        /// </summary>
        [DataField("命中")]
        public double Hit
        {
            get
            {
                return hit;
            }

            set
            {
                hit = value;
            }
        }
        /// <summary>
        /// 闪避
        /// </summary>
        [DataField("闪避")]
        public double Sidestep
        {
            get
            {
                return sidestep;
            }

            set
            {
                sidestep = value;
            }
        }
    }
}
