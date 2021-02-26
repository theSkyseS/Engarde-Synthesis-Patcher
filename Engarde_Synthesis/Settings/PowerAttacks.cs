using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record PowerAttacks
    {
        [SynthesisSettingName("Enhanced power attack and controls")]
        public bool powerAttackTweaks { get; set; } = true;
        [SynthesisSettingName("Power attack Cooldown")]
        public short powerAttackCooldown { get; set; } = 5;
        //public bool comboAttacks { get; set; } = false;
    }
}