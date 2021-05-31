using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Keyword
        {
            private static FormLink<IKeywordGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IKeywordGetter> MCT_ArmoredKW => Construct(0x28ff);
            public static FormLink<IKeywordGetter> MCT_WeakAgainstArmored => Construct(0xe3805);
            public static FormLink<IKeywordGetter> MCT_CanCritHigh => Construct(0xe3806);
            public static FormLink<IKeywordGetter> MCT_CanCritMed => Construct(0x111124);
            public static FormLink<IKeywordGetter> MCT_CanCritLow => Construct(0x111125);
            public static FormLink<IKeywordGetter> MCT_CritImmune => Construct(0x111126);
            public static FormLink<IKeywordGetter> MCT_InjuryAttackSpeed => Construct(0x13ea56);
            public static FormLink<IKeywordGetter> MCT_InjuryBleed => Construct(0x13ea57);
            public static FormLink<IKeywordGetter> MCT_InjuryStun => Construct(0x13ea58);
            public static FormLink<IKeywordGetter> MCT_InjuryKnockDown => Construct(0x13ea59);
            public static FormLink<IKeywordGetter> MCT_InjuryMoveSpeed => Construct(0x13ea5a);
            public static FormLink<IKeywordGetter> MCT_PowerAttackCoolDownKW => Construct(0x22c9dc);
            public static FormLink<IKeywordGetter> MCT_StaggerImmune => Construct(0x24a510);
            public static FormLink<IKeywordGetter> MCT_StaggerResist0 => Construct(0x2561c8);
            public static FormLink<IKeywordGetter> MCT_StaggerResist1 => Construct(0x2561c9);
            public static FormLink<IKeywordGetter> MCT_StaggerResist2 => Construct(0x2561ca);
            public static FormLink<IKeywordGetter> MCT_StaggerResist3 => Construct(0x2561cb);
            public static FormLink<IKeywordGetter> MCT_StaggerResist4 => Construct(0x2561cc);
            public static FormLink<IKeywordGetter> MCT_StaggerPower0 => Construct(0x25775b);
            public static FormLink<IKeywordGetter> MCT_StaggerPower1 => Construct(0x25775c);
            public static FormLink<IKeywordGetter> MCT_StaggerPower2 => Construct(0x25775d);
            public static FormLink<IKeywordGetter> MCT_StaggerPower3 => Construct(0x25775e);
            public static FormLink<IKeywordGetter> MCT_StaggerPower4 => Construct(0x25775f);
            public static FormLink<IKeywordGetter> MCT_SprintAttack => Construct(0x26d5a1);
            public static FormLink<IKeywordGetter> MCT_NormalAttackRight => Construct(0x26e067);
            public static FormLink<IKeywordGetter> MCT_NormalAttackLeft => Construct(0x26e068);
            public static FormLink<IKeywordGetter> MCT_StompAttack => Construct(0x2700b5);
            public static FormLink<IKeywordGetter> MCT_GiantRaceKW => Construct(0x270618);
            public static FormLink<IKeywordGetter> MCT_StaminaControlledKW => Construct(0x27210e);
            public static FormLink<IKeywordGetter> MCT_CanEnrage => Construct(0x272675);
            public static FormLink<IKeywordGetter> MCT_InjuryEffect => Construct(0x272bd9);
            public static FormLink<IKeywordGetter> MCT_DragonRaceKW => Construct(0x273140);
            public static FormLink<IKeywordGetter> MCT_DragonTailAttackLeft => Construct(0x27416b);
            public static FormLink<IKeywordGetter> MCT_DragonTailAttackRight => Construct(0x27416d);
            public static FormLink<IKeywordGetter> MCT_DragonTailAttack => Construct(0x27416e);
            public static FormLink<IKeywordGetter> MCT_BlockableSpell => Construct(0x277748);
            public static FormLink<IKeywordGetter> MCT_PowerBlockingKW => Construct(0x27ddb1);
            public static FormLink<IKeywordGetter> MCT_VerticalAttack => Construct(0x2808d7);
            public static FormLink<IKeywordGetter> MCT_PenetratesArmorKW => Construct(0x281901);
            public static FormLink<IKeywordGetter> MCT_WerewolfRaceKW => Construct(0x28db00);
            public static FormLink<IKeywordGetter> MCT_PaddedKW => Construct(0x28fd);
            public static FormLink<IKeywordGetter> MCT_DefensiveAttack => Construct(0x2936a2);
            public static FormLink<IKeywordGetter> MCT_SweepAttack => Construct(0x294169);
            public static FormLink<IKeywordGetter> MCT_KnockDownImmune => Construct(0x2961c9);
            public static FormLink<IKeywordGetter> MCT_NoStamina => Construct(0x2961ca);
            public static FormLink<IKeywordGetter> MCT_DamagesStamina => Construct(0x29672e);
        }
    }
}