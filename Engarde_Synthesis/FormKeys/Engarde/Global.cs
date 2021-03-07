namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Global
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Engarde.esp");
            public static FormKey MCT_StaggerMagnitudeBase => ModKey.MakeFormKey(0x25e324);
            public static FormKey MCT_CONTINUE => ModKey.MakeFormKey(0x289e);
            public static FormKey MCT_PowerAttackCoolDownTime => ModKey.MakeFormKey(0x2659c0);
            public static FormKey MCT_KeySheathe => ModKey.MakeFormKey(0x26648b);
            public static FormKey MCT_StartingStagger => ModKey.MakeFormKey(0x289f);
            public static FormKey MCT_IncrementStagger => ModKey.MakeFormKey(0x28a5);
            public static FormKey MCT_swingStaminaMult => ModKey.MakeFormKey(0x28c7);
            public static FormKey MCT_swingStaminaRecoverMult => ModKey.MakeFormKey(0x28c8);
            public static FormKey MCT_swingStaminaRecoverLag => ModKey.MakeFormKey(0x2917);
            public static FormKey MCT_CombatSpeed => ModKey.MakeFormKey(0x978c0);
            public static FormKey MCT_CombatSpeedBowLag => ModKey.MakeFormKey(0x978c3);
            public static FormKey MCT_AnimationSpeedNPC => ModKey.MakeFormKey(0xbafe4);
            public static FormKey MCT_AnimationSpeedDefault => ModKey.MakeFormKey(0xbafe5);
            public static FormKey MCT_AnimationSpeedPlayer => ModKey.MakeFormKey(0xc51ed);
            public static FormKey MCT_PlayerAttackControlEnabled => ModKey.MakeFormKey(0x24644d);
            public static FormKey MCT_PowerAttackControlEnabled => ModKey.MakeFormKey(0x24644e);
            public static FormKey MCT_AttackSpeedFixEnabled => ModKey.MakeFormKey(0x24747e);
            public static FormKey MCT_PowerAttackSlowTimeEnabled => ModKey.MakeFormKey(0x2484a9);
            public static FormKey MCT_PowerAttackEtherealizeEnabled => ModKey.MakeFormKey(0x2484aa);
            public static FormKey MCT_PowerAttackInuryEnabled => ModKey.MakeFormKey(0x2484ab);
            public static FormKey MCT_PowerAttackDualSpeedMult => ModKey.MakeFormKey(0x2484ad);
            public static FormKey MCT_BashStaminaMult => ModKey.MakeFormKey(0x248f73);
            public static FormKey MCT_SprintToSneakEnabled => ModKey.MakeFormKey(0x289fb6);
            public static FormKey MCT_CGOIntegrationEnabled => ModKey.MakeFormKey(0x28a519);
            public static FormKey MCT_KeySneak => ModKey.MakeFormKey(0x28afdf);
            public static FormKey MCT_DaggerBashEnabled => ModKey.MakeFormKey(0x249a44);
            public static FormKey MCT_MinimumBlockStamina => ModKey.MakeFormKey(0x249a45);
            public static FormKey MCT_StaggerByArrowEnabled => ModKey.MakeFormKey(0x2551a0);
            public static FormKey MCT_swingStaminaBase => ModKey.MakeFormKey(0x25e323);
        }
    }
}
