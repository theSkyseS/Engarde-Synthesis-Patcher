using System.Collections.Generic;
using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record DefensiveActions
    {
        [SynthesisSettingName("Dodge and power block with the sneak key")]
        public bool defensiveActions { get; set; } = true;
        
        [SynthesisSettingName("Heavy Armor step dodge animation:")]
        public DodgeType heavyArmorDodge { get; set; } = DodgeType.Roll;

        [SynthesisSettingName("Light Armor step dodge animation:")]
        public DodgeType lightArmorDodge { get; set; } = DodgeType.Step;
    }
}