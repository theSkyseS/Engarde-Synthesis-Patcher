using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Enderal
    {
        public static class Spell
        {
            // Enderal modifies the original Skyrim.esm
            public readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ISpellGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            
            public static FormLink<ISpellGetter> QyranianStance => Construct(0x0f865a);
        }
    }
}
