using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> MCT_ActorBehaviorOutOfStaminaRecover2Spell => Construct(0x2536ab);
            public static FormLink<ISpellGetter> MCT_TestContactSpell => Construct(0x253c0f);
            public static FormLink<ISpellGetter> MCT_SidePowerAttackSpell => Construct(0x254178);
            public static FormLink<ISpellGetter> MCT_InjurySpell => Construct(0x2546db);
            public static FormLink<ISpellGetter> MCT_BackPowerAttackSpell => Construct(0x257cc4);
            public static FormLink<ISpellGetter> MCT_PowerAttackingSpell => Construct(0x262e8f);
            public static FormLink<ISpellGetter> MCT_BashAttackSpell => Construct(0x27061a);
            public static FormLink<ISpellGetter> MCT_PowerAttackSpell => Construct(0x27061e);
            public static FormLink<ISpellGetter> MCT_EnrageSpell => Construct(0x272111);
            public static FormLink<ISpellGetter> MCT_EnrageTimerSpell => Construct(0x272674);
            public static FormLink<ISpellGetter> MCT_StaminaDrainWhileFlying => Construct(0x27313d);
            public static FormLink<ISpellGetter> MCT_DragonTailSpell => Construct(0x273c06);
            public static FormLink<ISpellGetter> MCT_DragonCloakSpell => Construct(0x27416a);
            public static FormLink<ISpellGetter> MCT_DragonBiteAttackSpell => Construct(0x2746d4);
            public static FormLink<ISpellGetter> MCT_FrostSlowSpell => Construct(0x27923b);
            public static FormLink<ISpellGetter> MCT_PowerBlockingSpell => Construct(0x27a7cd);
            public static FormLink<ISpellGetter> MCT_PowerBashAttackSpell => Construct(0x27c2c0);
            public static FormLink<ISpellGetter> MCT_NPCDodgingSpell => Construct(0x28036f);
            public static FormLink<ISpellGetter> MCT_DodgingHorizontalSpell => Construct(0x2808d6);
            public static FormLink<ISpellGetter> MCT_BonusArmor500 => Construct(0x284417);
            public static FormLink<ISpellGetter> MCT_BonusArmor250 => Construct(0x28441c);
            public static FormLink<ISpellGetter> MCT_BurningSpell => Construct(0x284ee2);
            public static FormLink<ISpellGetter> MCT_ShoutCoolDown5Spell => Construct(0x285f0f);
            public static FormLink<ISpellGetter> MCT_ShoutCoolDown10Spell => Construct(0x286475);
            public static FormLink<ISpellGetter> MCT_ShoutCoolDown15Spell => Construct(0x286476);
            public static FormLink<ISpellGetter> MCT_DragonAlduinRaceSpell => Construct(0x28647a);
            public static FormLink<ISpellGetter> MCT_DefaultRaceSpell => Construct(0x803);
            public static FormLink<ISpellGetter> MCT_TestSpell => Construct(0x289a);
            public static FormLink<ISpellGetter> MCT_TestIsMovingSpell => Construct(0x497c);
            public static FormLink<ISpellGetter> MCT_NoStaminaRegenWhileRunning => Construct(0x64e95);
            public static FormLink<ISpellGetter> MCT_TestAnimationVariablesSpell => Construct(0x55b89);
            public static FormLink<ISpellGetter> MCT_UpdateWeaponSpeedMult => Construct(0x28db01);
            public static FormLink<ISpellGetter> MCT_TestSendAnimationEventSpell => Construct(0x5450);
            public static FormLink<ISpellGetter> MCT_PowerAttackCoolDownSpell => Construct(0x69f9f);
            public static FormLink<ISpellGetter> MCT_BeastTackleAttackSpell => Construct(0x28e06d);
            public static FormLink<ISpellGetter> MCT_CombatFocusPower => Construct(0xa1ace);
            public static FormLink<ISpellGetter> MCT_DragonRaceSpell => Construct(0xca2f1);
            public static FormLink<ISpellGetter> MCT_BeastBleedAttackSpell => Construct(0x28e5d0);
            public static FormLink<ISpellGetter> MCT_TestDisarm => Construct(0xf7c18);
            public static FormLink<ISpellGetter> MCT_Volnerability1Spell => Construct(0x148c5f);
            public static FormLink<ISpellGetter> MCT_BaseWeaponSpeedMultSpell => Construct(0x194b7c);
            public static FormLink<ISpellGetter> MCT_TestStaggerTargetSpell => Construct(0x1ae087);
            public static FormLink<ISpellGetter> MCT_Volnerability5Spell => Construct(0x1db9a0);
            public static FormLink<ISpellGetter> MCT_DualWieldCombo2Spell => Construct(0x2041bd);
            public static FormLink<ISpellGetter> MCT_DodgingAllSpell => Construct(0x294c31);
            public static FormLink<ISpellGetter> MCT_DualWieldCombo3Spell => Construct(0x2041c1);
            public static FormLink<ISpellGetter> MCT_PlayerAttackWillWindUpAbility => Construct(0x29519c);
            public static FormLink<ISpellGetter> MCT_CritAttackSpell => Construct(0x23bce7);
            public static FormLink<ISpellGetter> MCT_DefaultRacePlayerSpell => Construct(0x231ae3);
            public static FormLink<ISpellGetter> MCT_ActorBehaviorAttackWindUpSpell => Construct(0x295198);
            public static FormLink<ISpellGetter> MCT_DualPowerAttackSpell => Construct(0x20e3cf);
            public static FormLink<ISpellGetter> MCT_TestSlowDownTapering => Construct(0x246450);
            public static FormLink<ISpellGetter> MCT_MoveSpeedPenaltyTemporarySpell => Construct(0x295c63);
            public static FormLink<ISpellGetter> MCT_PowerAttackedSlow01TimeSpell => Construct(0x246451);
            public static FormLink<ISpellGetter> MCT_ArrowAttackedSlowTimeSpell => Construct(0x246453);
            public static FormLink<ISpellGetter> MCT_CombatFocusActivatedAbility => Construct(0x250b76);
            public static FormLink<ISpellGetter> MCT_CombatFocusPowerLesser => Construct(0x250612);
            public static FormLink<ISpellGetter> MCT_CombatFocusAbility => Construct(0x24e5c2);
            public static FormLink<ISpellGetter> MCT_NPCRaceSpell => Construct(0x24e051);
            public static FormLink<ISpellGetter> MCT_DodgingSpell => Construct(0x24bffe);
            public static FormLink<ISpellGetter> MCT_CombatFocusCoolDownSpell => Construct(0x250b79);
            public static FormLink<ISpellGetter> MCT_MeleeActorMonitorSpell => Construct(0x251644);
            public static FormLink<ISpellGetter> MCT_MeleeActorMonitorAbility => Construct(0x251647);
            public static FormLink<ISpellGetter> MCT_ActorBehaviorOutOfStaminaRecover1Spell => Construct(0x25211c);
            public static FormLink<ISpellGetter> MCT_NormalAttackSpell => Construct(0x253145);
        }
    }
}
