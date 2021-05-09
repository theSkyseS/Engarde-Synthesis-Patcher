using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Synthesis.Settings;

namespace Engarde_Synthesis.Settings
{
    public record Settings
    {
	    [SynthesisSettingName("Attack Speed Fix")]
        public bool fixAttackSpeed { get; set; } = true;
        
        [SynthesisSettingName("Normal attacks:")]
        public BasicAttacks basicAttacks { get; set; } = new();

        [SynthesisSettingName("Power attacks:")]
        public PowerAttacks powerAttacks { get; set; } = new();

        [SynthesisSettingName("Defensive actions:")]
        public DefensiveActions defensiveActions { get; set; } = new();

        [SynthesisSettingName("Stagger settings:")]
        public StaggerSettings staggerSettings { get; set; } = new();

        [SynthesisSettingName("Stamina settings:")]
        public StaminaSettings staminaSettings { get; set; } = new();

        [SynthesisSettingName("NPC settings:")]
        public NpcSettings npcSettings { get; set; } = new();
        
        [SynthesisSettingName("Movement:")]
        public MovementSettings movementSettings { get; set; } = new();

        [SynthesisSettingName("Weapon stats:")]
        public WeaponSettings weaponSettings { get; set; } = new();

        [SynthesisSettingName("Combat focus settings:")]
        public CombatFocus combatFocus { get; set; } = new();
        

        //public float enchantMult { get; set; } = 1.5f;
        [SynthesisIgnoreSetting]
        public int injuryTimeMultiplier { get; set; } = 1;
        [SynthesisIgnoreSetting]
        public bool permanentCombatFocus { get; set; } = false;
    }
}
