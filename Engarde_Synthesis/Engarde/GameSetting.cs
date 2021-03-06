namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Engarde.esp");
            public static FormKey fObjectHitWeaponReach => ModKey.MakeFormKey(0xd62);
            public static FormKey fWeaponTwoHandedAnimationSpeedMult => ModKey.MakeFormKey(0x4418);
            public static FormKey fAIPowerAttackRecoilBonus => ModKey.MakeFormKey(0xa8ef);
            public static FormKey fPlayerMaxResistance => ModKey.MakeFormKey(0x25e322);
        }
    }
}
