using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Engarde
    {
        public static class MovementType
        {
            private static FormLink<IMovementTypeGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));

            public static FormLink<IMovementTypeGetter> GargoyleDefault_MT => Construct(0xd036);
        }
    }
}
