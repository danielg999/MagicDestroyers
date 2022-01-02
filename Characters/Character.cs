using System;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        private int healthPoints;
        private int level;
        private string name;
        private Faction faction;

        private Armor bodyArmor;
        private Weapon weapon;

        private bool isAlive;
        private int scores;

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

        public Armor BodyArmor {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public bool IsAlive {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        public int Scores {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
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

        public abstract int Attack();
        public abstract int SpecialAttack();
        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if(this.Defend() < damage)
            {
                this.healthPoints = this.HealthPoints - damage + this.Defend();
                if(this.healthPoints <= 0)
                {
                    this.IsAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage is not enough to hurt me!");
            }

            if (!this.IsAlive)
            {
                Tools.TypeSpecificColorfullCW($"{this.Name} received {damage} damage from {attackerName} damage and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfullCW($"{this.Name} received {damage} damage from {attackerName} damage and now has {this.HealthPoints} health points!", type);
            }
        }

        public void WonBattle()
        {
            this.scores++;
            if(this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
