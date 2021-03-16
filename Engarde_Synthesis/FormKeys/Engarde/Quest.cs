using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Quest
        {
            private static FormLink<IQuestGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> MCT_DodgeHorizontalKeyListener => Construct(0x2946cd);
            public static FormLink<IQuestGetter> MCT_DodgeKeyListener => Construct(0x2946cc);
            public static FormLink<IQuestGetter> MCT_WeaponSwingListener => Construct(0x28c012);
            public static FormLink<IQuestGetter> MCT_Main => Construct(0x804);
            public static FormLink<IQuestGetter> MCT_MCM => Construct(0x28bc);
            public static FormLink<IQuestGetter> MCT_PowerAttackListener => Construct(0x834ad);
            public static FormLink<IQuestGetter> MCT_GetUpListener => Construct(0x291bb0);
            public static FormLink<IQuestGetter> MCT_AttackDrainsStamina => Construct(0x13ea5b);
            public static FormLink<IQuestGetter> MCT_PlayerAttackController => Construct(0x19ed81);
            public static FormLink<IQuestGetter> MCT_EscapeListener => Construct(0x24b537);
            public static FormLink<IQuestGetter> MCT_StatChecker => Construct(0x2510df);
            public static FormLink<IQuestGetter> MCT_DirectionalKeyForwardListener => Construct(0x262e8d);
            public static FormLink<IQuestGetter> MCT_ModifierKeyListener => Construct(0x263ec1);
            public static FormLink<IQuestGetter> MCT_WeaponSwingLeftListener => Construct(0x298781);
            public static FormLink<IQuestGetter> MCT_DirectionalKeyBackListener => Construct(0x26498d);
            public static FormLink<IQuestGetter> MCT_DirectionalKeyRightListener => Construct(0x26498e);
            public static FormLink<IQuestGetter> MCT_DirectionalKeyLeftListener => Construct(0x26498f);
            public static FormLink<IQuestGetter> MCT_SheathKeyListener => Construct(0x2659c1);
            public static FormLink<IQuestGetter> MCT_SneakKeyListener => Construct(0x27d2e9);
            public static FormLink<IQuestGetter> MCT_PowerBlockKeyListener => Construct(0x27ede1);
            public static FormLink<IQuestGetter> MCT_CGOIntegration => Construct(0x28a51a);
        }
    }
}
