using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record BasicAttacks
    {
        [SynthesisSettingName("Enhanced normal attacks and controls")]
        public bool basicAttackTweaks = true;
        [SynthesisSettingName("Include Dual Wield tweaks")]
        public bool dwAttackTweaks = true;
        [SynthesisSettingName("Alternate swings for Dual Wield (Uncheck for MCO)")]
        public bool dwAlternateSwings = true;
        [SynthesisSettingName("Include Unarmed tweaks")]
        public bool h2HAttackTweaks = true;
        [SynthesisSettingName("Spellsword can block")]
        public bool spellSwordBlocking = true;

    }
}