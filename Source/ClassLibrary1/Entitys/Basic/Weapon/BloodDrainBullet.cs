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
    public class BloodDrainBullet : Bullet
    {

        protected override void Impact(Thing hitThing, bool blockedByShield = false)
        {
            
            base.Impact(hitThing, blockedByShield);

            Pawn victim = hitThing as Pawn;
            if (victim == null) return;
            if (victim.Downed) return;
            if(!victim.health.hediffSet.HasHediff(HediffDefOf.BloodLoss))
            {
                Hediff setDiff = HediffMaker.MakeHediff(HediffDefOf.BloodLoss,victim);
                setDiff.Severity = 0.25f;
                victim.health.AddHediff(setDiff);
            }
            else
            {
                Hediff bloodHediff = victim.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BloodLoss);
                bloodHediff.Severity += 0.05f;
            }
        }
    }
}
