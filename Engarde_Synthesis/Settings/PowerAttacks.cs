using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record PowerAttacks
    {
        [SynthesisSettingName("Enhanced power attack and controls")]
        public bool powerAttackTweaks { get; set; } = true;
        [SynthesisSettingName("Power attack Cooldown")]
        public short powerAttackCooldown { get; set; } = 5;
        [SynthesisSettingName("Forward power attack damage multiplier")]
        public float forwardDamageMult { get; set; } = 1;
        [SynthesisSettingName("Side power attack damage multiplier")]
        public float sideDamageMult { get; set; } = 1;
        //public bool comboAttacks { get; set; } = false;
    }
}