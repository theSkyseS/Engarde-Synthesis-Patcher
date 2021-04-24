using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record WeaponSettings
    {
        [SynthesisSettingName("Weapon speed multiplier")]
        public float weaponSpeedMult { get; set; } = 1f;
        [SynthesisSettingName("Weapon reach multiplier")]
        [SynthesisTooltip("0.7 is recommended for 3rd person, 1.0 for 1st")]
        public float weaponReachMult { get; set; } = 0.7f;
        [SynthesisSettingName("Weapon damage multiplier")]
        public float weaponDamageMult { get; set; } = 2f;
        [SynthesisSettingName("Weapon critical damage multiplier")]
        public float weaponCritDamageMult { get; set; } = 1f;
        [SynthesisSettingName("Bladed weapons are weak to armored foes")]
        public bool weakToArmor { get; set; } = true;
        [SynthesisSettingName("Blunt weapons damages stamina and power attack knocks down low stamina foes")]
        public bool bluntKnocksDown { get; set; } = true;
    }
}