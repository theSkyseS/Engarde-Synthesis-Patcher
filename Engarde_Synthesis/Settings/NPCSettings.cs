using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record NpcSettings
    {
        [SynthesisSettingName("Can not perform kill move on player")]
        public bool playerKillMoveImmune { get; set; } = false;
        [SynthesisSettingName("Low stamina slows down movement and attack speed / causes recuperation")]
        public bool staminaManagement { get; set; } = true;
        [SynthesisSettingName("NPC dodging")]
        public bool npcDodging { get; set; } = true;
        [SynthesisSettingName("First normal attack in a combo have windup (Experimental)")]
        public bool npcAttackWindup { get; set; } = false;
        [SynthesisSettingName("Turning acceleration multiplier, higher makes npc react slower")]
        public int angularAccelerationMult { get; set; } = 7;
        [SynthesisSettingName("Unarmed / Creature physical attack damage multiplier")]
        public float unarmedDamageMult { get; set; } = 2f;
        [SynthesisSettingName("Adds bonus armor to armored looking creatures")]
        public bool addArmorToArmored { get; set; } = true;
        [SynthesisSettingName("Enhanced Werewolves")]
        public bool werewolfTweaks { get; set; } = true;
        [SynthesisSettingName("Enhanced Giants")]
        public bool giantTweaks { get; set; } = true;
        [SynthesisSettingName("Enhanced Dragons")]
        public bool dragonTweaks { get; set; } = true;
    }
}