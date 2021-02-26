using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record StaminaSettings
    {
        [SynthesisSettingName("Stamina regen penalty applied when running")]
        public int runningStaminaRatePenalty { get; set; } = 300;
        [SynthesisSettingName("Minimum stamina to attack")]
        public int minimumStamina { get; set; } = 5;
        [SynthesisSettingName("Minimum stamina to dodge")]
        public int minimumDodgeStamina { get; set; } = 0;
    }
}