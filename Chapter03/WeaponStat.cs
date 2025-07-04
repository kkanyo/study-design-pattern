﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study.Chapter03
{
    internal class WeaponStat : EquipmentStat
    {
        public WeaponStat(double atkP, double criR, double criDmg)
        {
            itemName = "Weapon";
            itemID = 1000;

            statList.Add( "공격력", atkP );
            statList.Add( "치명타 확률", criR );
            statList.Add( "치명타율", criDmg );
        }

        public override Dictionary<string, double> GetStat()
        {
            return statList;
        }
    }
}
