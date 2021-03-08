using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public class CombatFocus
    {
        [SynthesisSettingName("World speed multiplier, higher is faster")]
        public float worldSpeedMult { get; set; } = 1;

        [SynthesisSettingName("Player speed multiplier, higher is faster")]
        public float playerSpeedMult { get; set; } = 1;

        [SynthesisSettingName("Duration multiplier, higher is longer")]
        public float durationMult { get; set; } = 1;
    }
}