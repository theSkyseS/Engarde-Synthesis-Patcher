using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record DefensiveActions
    {
        [SynthesisSettingName("Dodge and power block with the sneak key")]
        public bool defensiveActions { get; set; } = true;
        [SynthesisSettingName("Heavy Armor dodge animation:")]
        public DodgeType heavyArmorDodge = DodgeType.Roll;
        [SynthesisSettingName("Light Armor dodge animation:")]
        public DodgeType lightArmorDodge = DodgeType.Step;
    }

    public enum DodgeType
    {
        Roll = 0,
        Step = 1
        
    }
}