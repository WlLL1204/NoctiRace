using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;
using UnityEngine;


namespace NoctiRace
{
    internal class BloodDrainBullet:Bullet
    {
        protected override void Impact(Thing hitThing, bool blockedByShield = false)
        {
            base.Impact(hitThing, blockedByShield);
            Pawn victim= hitThing as Pawn;

        }

    }
}
