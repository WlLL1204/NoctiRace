using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;
using Verse.Noise;

namespace NoctiRace
{

    public class NR_BloodHarvester : Building
    {

        protected override void Tick()
        {

            Room room = this.GetRoom();
            List<Pawn> target;
            target = room.ContainedAndAdjacentThings.OfType<Pawn>().ToList();

            if (room != null)
            {
                target = room.ContainedAndAdjacentThings.OfType<Pawn>().ToList();
                target = target.Where(p => p.IsPrisonerOfColony).ToList();
                int count = target.Count();

                foreach (Pawn pawn in target)
                {
                    if (!pawn.health.hediffSet.HasHediff(HediffDefOf.BloodLoss))
                    {
                        Hediff setDiff = HediffMaker.MakeHediff(HediffDefOf.BloodLoss, pawn);
                        setDiff.Severity = 0.25f;
                        pawn.health.AddHediff(setDiff);
                    }
                    else
                    {
                        if (pawn.Downed) break;
                        Hediff bloodHediff = pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BloodLoss);
                        bloodHediff.Severity += 0.05f;
                    }
                }
            }
            else
            {
            }

        }

        public override void TickLong()
        {

            base.TickLong();

              

        }
    }
}