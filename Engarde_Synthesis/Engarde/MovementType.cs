namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class MovementType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Engarde.esp");
            public static FormKey GargoyleDefault_MT => ModKey.MakeFormKey(0xd036);
        }
    }
}
