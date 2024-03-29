﻿using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public override int ManaPoints
        {
            get
            {
                return base.ManaPoints;
            }
            set
            {
                if (value >= 0 && value <= 25)
                {
                    base.ManaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Ability points for {base.Name} is out of range, it should be between 0 and 10.");
                }
            }
        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"HelathPoints for {base.Name} is out of range, it should between 0 and 150.");
                }
            }
        }

        public Necromancer()
            : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.HEALTH_POINTS)
        {

        }

        public Necromancer(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            base.Faction = Faction.Spellcasters;
            base.ManaPoints = Consts.Necromancer.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 6;
        }

        public int VampireTouch()
        {
            throw new NotImplementedException();
        }

        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}
