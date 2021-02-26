using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record BasicAttacks
    {
        [SynthesisSettingName("Enhanced normal attacks and controls")]
        public bool basicAttackTweaks = true;
        [SynthesisSettingName("Include Dual Wield tweaks")]
        public bool dwAttackTweaks = true;
        [SynthesisSettingName("Include Unarmed tweaks")]
        public bool h2HAttackTweaks = true;
    }
}