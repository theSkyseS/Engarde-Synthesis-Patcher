using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record StaggerSettings
    {
        [SynthesisSettingName("Stagger on melee weapons hits")]
        public bool weaponStagger { get; set; } = true;

        [SynthesisSettingName("Stagger on bow and crossbow hits")]
        public bool bowStagger { get; set; } = true;
        [SynthesisSettingName("Stagger on weapon critical strikes")]
        public bool critStagger { get; set; } = true;
    }
}