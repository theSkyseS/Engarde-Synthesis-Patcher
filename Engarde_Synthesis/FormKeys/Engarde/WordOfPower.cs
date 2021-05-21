using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class WordOfPower
        {
            private static FormLink<IWordOfPowerGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IWordOfPowerGetter> MCT_FocusWord => Construct(0x24e054);
            public static FormLink<IWordOfPowerGetter> MCT_SpeedWord => Construct(0x24e059);
            public static FormLink<IWordOfPowerGetter> MCT_CombatWord => Construct(0x24e057);
        }
    }
}
