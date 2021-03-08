namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Engarde.esp");
            public static FormKey MCT_DodgeHorizontalKeyListener => ModKey.MakeFormKey(0x2946cd);
            public static FormKey MCT_DodgeKeyListener => ModKey.MakeFormKey(0x2946cc);
            public static FormKey MCT_WeaponSwingListener => ModKey.MakeFormKey(0x28c012);
            public static FormKey MCT_Main => ModKey.MakeFormKey(0x804);
            public static FormKey MCT_MCM => ModKey.MakeFormKey(0x28bc);
            public static FormKey MCT_PowerAttackListener => ModKey.MakeFormKey(0x834ad);
            public static FormKey MCT_GetUpListener => ModKey.MakeFormKey(0x291bb0);
            public static FormKey MCT_AttackDrainsStamina => ModKey.MakeFormKey(0x13ea5b);
            public static FormKey MCT_PlayerAttackController => ModKey.MakeFormKey(0x19ed81);
            public static FormKey MCT_EscapeListener => ModKey.MakeFormKey(0x24b537);
            public static FormKey MCT_StatChecker => ModKey.MakeFormKey(0x2510df);
            public static FormKey MCT_DirectionalKeyForwardListener => ModKey.MakeFormKey(0x262e8d);
            public static FormKey MCT_ModifierKeyListener => ModKey.MakeFormKey(0x263ec1);
            public static FormKey MCT_WeaponSwingLeftListener => ModKey.MakeFormKey(0x298781);
            public static FormKey MCT_DirectionalKeyBackListener => ModKey.MakeFormKey(0x26498d);
            public static FormKey MCT_DirectionalKeyRightListener => ModKey.MakeFormKey(0x26498e);
            public static FormKey MCT_DirectionalKeyLeftListener => ModKey.MakeFormKey(0x26498f);
            public static FormKey MCT_SheathKeyListener => ModKey.MakeFormKey(0x2659c1);
            public static FormKey MCT_SneakKeyListener => ModKey.MakeFormKey(0x27d2e9);
            public static FormKey MCT_PowerBlockKeyListener => ModKey.MakeFormKey(0x27ede1);
            public static FormKey MCT_CGOIntegration => ModKey.MakeFormKey(0x28a51a);
        }
    }
}
