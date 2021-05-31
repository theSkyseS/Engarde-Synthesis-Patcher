using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Perk
        {
            private static FormLink<IPerkGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IPerkGetter> MCT_TestDamgeMult => Construct(0x32477);
            public static FormLink<IPerkGetter> MCT_ShieldSweepAttack => Construct(0x8d6bd);
            public static FormLink<IPerkGetter> MCT_CritHighOnStandingPowerAttac => Construct(0xc51ec);
            public static FormLink<IPerkGetter> MCT_SpellPowerBlock => Construct(0x285449);
            public static FormLink<IPerkGetter> MCT_SpellBlock => Construct(0x285448);
            public static FormLink<IPerkGetter> MCT_CritMedOnStandingPowerAttack => Construct(0x125537);
            public static FormLink<IPerkGetter> MCT_CritLowOnStandingPowerAttack => Construct(0x125538);
            public static FormLink<IPerkGetter> MCT_AttackSweepOnTwohand => Construct(0x12a63a);
            public static FormLink<IPerkGetter> MCT_DamageDoublesOnTwoHandSidePowerAttack => Construct(0x15d066);
            public static FormLink<IPerkGetter> MCT_AttackSweep => Construct(0x294168);
            public static FormLink<IPerkGetter> MCT_VolnerabilityCritical => Construct(0x1db9a2);
            public static FormLink<IPerkGetter> MCT_Crit100 => Construct(0x2134d3);
            public static FormLink<IPerkGetter> MCT_NoCritChanceOnImmune => Construct(0x2185d5);
            public static FormLink<IPerkGetter> MCT_PowerAttackedSlowTimePerk => Construct(0x2469b9);
            public static FormLink<IPerkGetter> MCT_MultDamageOnForwardPowerAttack => Construct(0x297cbb);
            public static FormLink<IPerkGetter> MCT_SpellWeaponBlock => Construct(0x294c33);
            public static FormLink<IPerkGetter> MCT_MultDamageOnSidePowerAttack => Construct(0x29821e);
            public static FormLink<IPerkGetter> MCT_ReduceDamageWithBladesCreatures => Construct(0x291baf);
            public static FormLink<IPerkGetter> MCT_ReduceDamageFromBladesCreatures => Construct(0x291bae);
            public static FormLink<IPerkGetter> MCT_ArrowAttackedSlowTimePerk => Construct(0x24e052);
            public static FormLink<IPerkGetter> MCT_TestApplyCombatHitPerk => Construct(0x253c10);
            public static FormLink<IPerkGetter> MCT_ReduceDamageOnFrontalArrows => Construct(0x269a63);
            public static FormLink<IPerkGetter> MCT_IncreasesDamageFromEnraged => Construct(0x272bda);
            public static FormLink<IPerkGetter> MCT_NoStagger => Construct(0x27f8a7);
            public static FormLink<IPerkGetter> MCT_ReduceDamageFromBlades => Construct(0x280370);
            public static FormLink<IPerkGetter> MCT_ReduceDamageWithBlades => Construct(0x2818ff);
            public static FormLink<IPerkGetter> MCT_IncreasedDamageWithPenetratesArmor => Construct(0x281900);
            public static FormLink<IPerkGetter> MCT_IncreasedDamageFromPenetrationWeapon => Construct(0x281902);
            public static FormLink<IPerkGetter> MCT_ReduceDamageWhileDefensiveAttack => Construct(0x2936a3);
            public static FormLink<IPerkGetter> MCT_IncreasedDamageFromPenetrationActor => Construct(0x281903);
            public static FormLink<IPerkGetter> MCT_NoDamageToDodging => Construct(0x283951);
            public static FormLink<IPerkGetter> MCT_FullProtection => Construct(0x33ef);
        }
    }
}
