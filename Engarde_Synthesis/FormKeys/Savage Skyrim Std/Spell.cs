using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SavageSkyrim
    {
        public static class Spell
        {
            public readonly static ModKey ModKey = ModKey.FromNameAndExtension("Savage Skyrim Std.esp");
            private static FormLink<ISpellGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> __Ab_Animal_Excl_MammothCrushAbilityCloak => Construct(0x1a499);
            public static FormLink<ISpellGetter> __AA_Animal_ForceThrow_Small => Construct(0x2366d);
            public static FormLink<ISpellGetter> __AB_Animal_GNL_Dem_Fire_TochFears => Construct(0x29cd8);
            public static FormLink<ISpellGetter> __AB_Animal_GNL_Dem_OnlyFireFears => Construct(0x2b262);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_BleedAttack_Wolf => Construct(0x2ff4a);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_BleedAttack_Bear => Construct(0x2ff4b);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_BleedAttack_SabreCat => Construct(0x2ff4d);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_BleedAttack_Skeever => Construct(0x2ff4e);
            public static FormLink<ISpellGetter> __AA_Animal_ForceStagger => Construct(0x34588);
            public static FormLink<ISpellGetter> __AB_Animal_Excl_MammothFears => Construct(0x3504d);
            public static FormLink<ISpellGetter> __AB_Animal_Excl_MammothCrushSpell_DMG => Construct(0x355b0);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Dem_WolfPacksFears => Construct(0x39bb0);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Dem_SabreCatFears => Construct(0x39bb1);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Dem_BearFears => Construct(0x39bb3);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Dem_WolfFears => Construct(0x39bb5);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Rally_Wolf => Construct(0x3a67c);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Rally_WolfPack => Construct(0x3a67d);
            public static FormLink<ISpellGetter> z_Obsolete_zzz => Construct(0x3abe1);
            public static FormLink<ISpellGetter> __AB_Animal_GNL_Inj_Tiredness => Construct(0x3c16b);
            public static FormLink<ISpellGetter> __AB_Animal_GNL_Inj_Crit_Bleeding => Construct(0x3c6cf);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Rally_Sabrecat => Construct(0x3dc59);
            public static FormLink<ISpellGetter> __AB_Animal_PRED_Dem_IceWolf => Construct(0x6ba93);
            public static FormLink<ISpellGetter> __AA_Animal_ForceThrow_Big => Construct(0x85f2);
        }
    }
}
