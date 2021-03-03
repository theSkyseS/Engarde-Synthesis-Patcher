using System.Collections.Generic;
using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record DefensiveActions
    {
        [SynthesisSettingName("Dodge and power block with the sneak key")]
        public bool defensiveActions { get; set; } = true;

        //todo: restore enum
        [SynthesisSettingName("Heavy Armor step dodge animation:")]
        public bool heavyArmorDodge { get; set; } = false;

        [SynthesisSettingName("Light Armor step dodge animation:")]
        public bool lightArmorDodge { get; set; } = true;
    }
}