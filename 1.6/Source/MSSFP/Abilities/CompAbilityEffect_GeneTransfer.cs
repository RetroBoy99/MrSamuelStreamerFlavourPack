using System;
using RimWorld;
using Verse;

namespace MSSFP.Abilities;

public class CompAbilityEffect_GeneTransfer : CompAbilityEffect_ReimplantXenogerm
{
    public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
    {

        base.Apply(target, dest);


        Pawn caster = parent.pawn;
        if (caster.genes == null)
            return;

        caster.genes.SetXenotype(XenotypeDefOf.Baseliner);
        caster.genes.xenotypeName = null;
        caster.genes.iconDef = null;
        caster.genes.ClearXenogenes();
    }
}
