using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class GameSetting
        {
            private static FormLink<IGameSettingGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> fObjectHitWeaponReach => Construct(0xd62);
            public static FormLink<IGameSettingGetter> fWeaponTwoHandedAnimationSpeedMult => Construct(0x4418);
            public static FormLink<IGameSettingGetter> fAIPowerAttackRecoilBonus => Construct(0xa8ef);
            public static FormLink<IGameSettingGetter> fPlayerMaxResistance => Construct(0x25e322);
        }
    }
}
