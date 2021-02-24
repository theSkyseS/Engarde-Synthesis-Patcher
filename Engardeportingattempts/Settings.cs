using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engardeportingattempts
{
    public record Settings
    {
        public bool fixAttackSpeed = true;
		public bool playerKillMoveImmune = false;
		public bool basicAttackTweaks = true;
		public bool dwAttackTweaks = true;
		public bool h2hAttackTweaks = true;
		public bool comboAttacks = false; // implemented but not well; hidden for now
		public bool addArmorToArmored = true;
		public bool werewolfTweaks = true;
		public bool giantTweaks = true;
		public bool dragonTweaks = true;

		public bool powerAttackTweaks = true;
		public int powerAttackCooldown = 5;
		public int injuryTimeMultiplier = 1;
		public bool defensiveActions  = true;
		public string heavyArmorDodge = "roll";
		public string lightArmorDodge = "step";
		public bool sprintToSneak = true;

		public bool weaponStagger = true;
		public bool bowStagger = true;
		public bool critStagger = true;

		public int runningStaminaRatePenalty = 300;
		public int minimumStamina = 5;
		public int minimumDodgeStamina = 0;
		public int angularAccelerationMult = 7;
		public bool staminaManagement = true;
		public bool npcDodging = true;

		public bool attackCommitment = true;
		public bool patchSpeed = true;
		public int oneHandSpeed = 270;
		public int twoHandSpeed = 220;
		public int bowSpeed = 240;

		public double unarmedReachMult = 0.8;
		public double unarmedDamageMult = 2;

		public double weaponSpeedMult = 1;
		public double weaponReachMult = 0.7;
		public double weaponDamageMult = 2;
		public double weaponCritDamageMult = 1;
		//public double enchantMult = 1.5;

		public bool permanentCombatFocus = false;
    }
}
