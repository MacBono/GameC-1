﻿using Game.Engine.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Skills.UpgradedWeaponMoves
{
    [Serializable]
    class DoubleSlash:Skill
    {
        public DoubleSlash() : base("Double Slash", 20, 2)
        {
            PublicName = "double basic sword slash [requires sword]: 0.2*Str + 0.2*Pr damage [stab] and 0.2*Str + 0.2*Pr damage [incised]";
            RequiredItem = Skill.MainItem.sword;
        }
        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response1 = new StatPackage(DmgType.stab);
            response1.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);
            StatPackage response2 = new StatPackage(DmgType.cut);
            response2.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);

            StatPackage response3 = new StatPackage(DmgType.stab);
            response3.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);
            StatPackage response4 = new StatPackage(DmgType.cut);
            response4.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);

            response2.CustomText = "You use Double Sword Slash! (" + ((int)(0.2 * player.Strength) + (int)(0.2 * player.Precision)) + " stab damage, " + ((int)(0.2 * player.Strength) + (int)(0.2 * player.Precision)) + " incised damage)";
            return new List<StatPackage>() { response1, response2, response3, response4 };
        }
    }
}