using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class IdleAnimation
        {
            private static FormLink<IIdleAnimationGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IIdleAnimationGetter> OutOfStamina => Construct(0x2abdb);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttack => Construct(0x263956);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackLeftHandRoot => Construct(0x263957);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackLeftHandRight => Construct(0x26395a);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackLeftHandLeft => Construct(0x26395b);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRightHandRoot => Construct(0x26395c);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRightHandForward => Construct(0x26395d);
            public static FormLink<IIdleAnimationGetter> MCTPowerBashRoot => Construct(0x26395e);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackDual => Construct(0x263ec2);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackSprintRightHand => Construct(0x264989);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackSprintRoot => Construct(0x26498b);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackSprintLeftHand => Construct(0x264990);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRightHandRight => Construct(0x264992);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRightHandLeft => Construct(0x264993);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRightHandBackward => Construct(0x264994);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRightHandStanding => Construct(0x264995);
            public static FormLink<IIdleAnimationGetter> MCTLooseIdles => Construct(0x264ef8);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackSprintSink => Construct(0x264ef9);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackBashSink => Construct(0x264efa);
            public static FormLink<IIdleAnimationGetter> MCTPowerBashIntro => Construct(0x264efb);
            public static FormLink<IIdleAnimationGetter> MCTPowerBash => Construct(0x26b54f);
            public static FormLink<IIdleAnimationGetter> MCTComboAttack => Construct(0x26d59f);
            public static FormLink<IIdleAnimationGetter> MCTComboAttackStart => Construct(0x26d5a0);
            public static FormLink<IIdleAnimationGetter> MCTComboAttackDW => Construct(0x26d5a2);
            public static FormLink<IIdleAnimationGetter> MCTDodgeLightArmorBackward => Construct(0x27c823);
            public static FormLink<IIdleAnimationGetter> MCTPowerBlockRoot => Construct(0x27d2ea);
            public static FormLink<IIdleAnimationGetter> MCTDodgeHeavyArmorRight => Construct(0x27ddb2);
            public static FormLink<IIdleAnimationGetter> MCTDodgeHeavyArmorForward => Construct(0x27ddb3);
            public static FormLink<IIdleAnimationGetter> MCTHeavyArmorDodge => Construct(0x27ddb4);
            public static FormLink<IIdleAnimationGetter> MCTDodgeHeavyArmorBackward => Construct(0x27ddb5);
            public static FormLink<IIdleAnimationGetter> MCTDodgeHeavyArmorLeft => Construct(0x27ddb6);
            public static FormLink<IIdleAnimationGetter> MCTDefensiveMoves => Construct(0x27ddb7);
            public static FormLink<IIdleAnimationGetter> MCTDodgeLightArmorLeft => Construct(0x27ddb8);
            public static FormLink<IIdleAnimationGetter> MCTDodgeLightArmorRight => Construct(0x27ddb9);
            public static FormLink<IIdleAnimationGetter> MCTDodgeLightArmorForward => Construct(0x27f8a6);
            public static FormLink<IIdleAnimationGetter> MCTDodgeLightArmorStanding => Construct(0x27f8a8);
            public static FormLink<IIdleAnimationGetter> MCTDodgeHeavyArmorStanding => Construct(0x282e8c);
            public static FormLink<IIdleAnimationGetter> MCTFirstPersonRoot => Construct(0x28afe0);
            public static FormLink<IIdleAnimationGetter> MCTRoll1 => Construct(0x28afe1);
            public static FormLink<IIdleAnimationGetter> MCTRollForward1 => Construct(0x28afe2);
            public static FormLink<IIdleAnimationGetter> MCTRollRight1 => Construct(0x28afe3);
            public static FormLink<IIdleAnimationGetter> MCTRollLeft1 => Construct(0x28afe4);
            public static FormLink<IIdleAnimationGetter> MCTRollBack1 => Construct(0x28afe5);
            public static FormLink<IIdleAnimationGetter> MCTRollStanding1 => Construct(0x28afe6);
            public static FormLink<IIdleAnimationGetter> MCTStepForward1 => Construct(0x28b549);
            public static FormLink<IIdleAnimationGetter> MCTStepRight1 => Construct(0x28b54a);
            public static FormLink<IIdleAnimationGetter> MCTStepLeft1 => Construct(0x28b54b);
            public static FormLink<IIdleAnimationGetter> MCTStepBack1 => Construct(0x28b54c);
            public static FormLink<IIdleAnimationGetter> MCTStepStanding1 => Construct(0x28b54d);
            public static FormLink<IIdleAnimationGetter> MCTAttackLeftH2H => Construct(0x28c013);
            public static FormLink<IIdleAnimationGetter> MCTRoll => Construct(0x28fb5b);
            public static FormLink<IIdleAnimationGetter> MCTRollForward => Construct(0x28fb5c);
            public static FormLink<IIdleAnimationGetter> MCTRollRight => Construct(0x28fb5d);
            public static FormLink<IIdleAnimationGetter> MCTRollLeft => Construct(0x28fb5e);
            public static FormLink<IIdleAnimationGetter> MCTRollBack => Construct(0x28fb5f);
            public static FormLink<IIdleAnimationGetter> MCTLightArmorDodge => Construct(0x292113);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackRootBeast => Construct(0x29369e);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackForwardBeast => Construct(0x29369f);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackStandingBeast => Construct(0x2936a0);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackBackwardBeast => Construct(0x2936a1);
            public static FormLink<IIdleAnimationGetter> PlayerStaggerSink => Construct(0x2971f4);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackSprint2hw => Construct(0x297757);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackSprint2hm => Construct(0x297758);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackH2HRoot => Construct(0x298782);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackH2HRight => Construct(0x298783);
            public static FormLink<IIdleAnimationGetter> MCTPowerAttackH2HLeft => Construct(0x298784);
        }
    }
}
