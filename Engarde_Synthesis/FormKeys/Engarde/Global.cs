using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class Global
        {
            private static FormLink<IGlobalGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IGlobalGetter> MCT_KeySheathe => Construct(0x26648b);
            public static FormLink<IGlobalGetter> MCT_StartingStagger => Construct(0x289f);
            public static FormLink<IGlobalGetter> MCT_IncrementStagger => Construct(0x28a5);
            public static FormLink<IGlobalGetter> MCT_swingStaminaMult => Construct(0x28c7);
            public static FormLink<IGlobalGetter> MCT_swingStaminaRecoverMult => Construct(0x28c8);
            public static FormLink<IGlobalGetter> MCT_swingStaminaRecoverLag => Construct(0x2917);
            public static FormLink<IGlobalGetter> MCT_PlayerAttackControlEnabled => Construct(0x24644d);
            public static FormLink<IGlobalGetter> MCT_PowerAttackControlEnabled => Construct(0x24644e);
            public static FormLink<IGlobalGetter> MCT_AttackSpeedFixEnabled => Construct(0x24747e);
            public static FormLink<IGlobalGetter> MCT_PowerAttackSlowTimeEnabled => Construct(0x2484a9);
            public static FormLink<IGlobalGetter> MCT_PowerAttackEtherealizeEnabled => Construct(0x2484aa);
            public static FormLink<IGlobalGetter> MCT_PowerAttackInuryEnabled => Construct(0x2484ab);
            public static FormLink<IGlobalGetter> MCT_BashStaminaMult => Construct(0x248f73);
            public static FormLink<IGlobalGetter> MCT_SprintToSneakEnabled => Construct(0x289fb6);
            public static FormLink<IGlobalGetter> MCT_CGOIntegrationEnabled => Construct(0x28a519);
            public static FormLink<IGlobalGetter> MCT_KeySneak => Construct(0x28afdf);
            public static FormLink<IGlobalGetter> MCT_MinimumBlockStamina => Construct(0x249a45);
            public static FormLink<IGlobalGetter> MCT_StaggerByArrowEnabled => Construct(0x2551a0);
            public static FormLink<IGlobalGetter> MCT_swingStaminaBase => Construct(0x25e323);
            public static FormLink<IGlobalGetter> MCT_StaggerMagnitudeBase => Construct(0x25e324);
            public static FormLink<IGlobalGetter> MCT_CONTINUE => Construct(0x289e);
            public static FormLink<IGlobalGetter> MCT_PowerAttackCoolDownTime => Construct(0x2659c0);
            public static FormLink<IGlobalGetter> MCT_DefensiveActionEnabled => Construct(0x29924c);
            public static FormLink<IGlobalGetter> MCT_ModActivated => Construct(0x2997af);
            public static FormLink<IGlobalGetter> MCT_WeakToArmorEnabled => Construct(0x2a23c8); 
            public static FormLink<IGlobalGetter> MCT_SpellSwordBlockingEnabled => Construct(0x2a292c);
        }
    }
}
