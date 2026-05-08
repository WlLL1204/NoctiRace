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
    public class NR_NeedBlood : Need
    {
        public override void NeedInterval()
        {
        }
        public NR_NeedBlood(Pawn pawn)
    : base(pawn)
        {
            threshPercents = new List<float>();
            threshPercents.Add(0.8f);
            threshPercents.Add(0.6f);
            threshPercents.Add(0.4f);
            threshPercents.Add(0.2f);
            threshPercents.Add(0.05f);
        }

    }
}
