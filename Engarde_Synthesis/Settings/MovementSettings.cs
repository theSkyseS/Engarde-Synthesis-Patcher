using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record MovementSettings
    {
        [SynthesisSettingName("Attack commitment, removes skating while attacking")]
        public bool attackCommitment { get; set; } = true;
        [SynthesisSettingName("Patch in combat movement speed:")]
        public bool patchSpeed { get; set; } = true;
        [SynthesisSettingName("One hander / Dual Wield movement speed")]
        [SynthesisTooltip("270 is recommended")]
        public int oneHandSpeed { get; set; } = 270;
        [SynthesisSettingName("Two hander movement speed")]
        [SynthesisTooltip("220 is recommended")]
        public int twoHandSpeed { get; set; } = 220;
        [SynthesisSettingName("Bow movement speed")]
        [SynthesisTooltip("240 is recommended")]
        public int bowSpeed { get; set; } = 240;
    }
}