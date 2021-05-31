using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SavageSkyrim
    {
        private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Savage Skyrim Std.esp");

        public static class MagicEffect
        {
            private static FormLinkNullable<IMagicEffectGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));

            public static FormLinkNullable<IMagicEffectGetter> __A2_STHC_ForceThrow_1 => Construct(0x85f0);
            public static FormLinkNullable<IMagicEffectGetter> __A2_STHC_ForceThrow_2 => Construct(0x2366c);
            public static FormLinkNullable<IMagicEffectGetter> __A2_STHC_Stagger => Construct(0x34587);
        }
    }
}
