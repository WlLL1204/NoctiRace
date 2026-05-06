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
        float tick = 0;
        public override void TickLong()
        {
            base.TickLong();
            if(tick==0) Log.Message($"採血開始");
            Room a=null;
            
            Room room = this.GetRoom();
            List<Pawn> target;
            target = a.ContainedAndAdjacentThings.OfType<Pawn>().ToList();

            if (room != null)
            {
                target = room.ContainedAndAdjacentThings.OfType<Pawn>().ToList();
                target = target.Where(p => p.IsPrisonerOfColony).ToList();
                int count = target.Count();
                foreach (Pawn pawn in target)
                {
                    pawn.health.AddHediff(HediffDefOf.BloodLoss);
                    Log.Message($"{pawn.Name} の血を吸い上げました");
                }
            }else
            {
                Log.Message($"部屋がないよ");
            }
                tick++;
        }
    }
}