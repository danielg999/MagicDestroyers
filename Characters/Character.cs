using System;
using MagicDestroyers.Enums;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        private int healthPoints;
        private int level;
        private string name;
        private Faction faction;


        public virtual int HealthPoints {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value > 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Level for {this.Name} is out of range, it should be at least 1.");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Name should be length between 3 to 20 signs.");
                }
            }
        }

        public virtual Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
        public Character(string name, int level, int healthPoints)
            : this(name, level)
        {
            this.HealthPoints = healthPoints;
        }

        public abstract void Attack();
        public abstract void SpecialAttack();
        public abstract void Defend();
    }
}
