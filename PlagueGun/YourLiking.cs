using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace TST_PlagueGun
{
    public class ModExtension_PlagueBullet : DefModExtension
    {
        public float addHediffChance = 0.1f;
        public HediffDef hediffToAdd;
    }
}
