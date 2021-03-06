namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class WordOfPower
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Engarde.esp");
            public static FormKey MCT_CombatWord => ModKey.MakeFormKey(0x24e057);
            public static FormKey MCT_FocusWord => ModKey.MakeFormKey(0x24e054);
            public static FormKey MCT_SpeedWord => ModKey.MakeFormKey(0x24e059);
        }
    }
}
