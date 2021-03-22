using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Newtonsoft.Json;

namespace Engarde_Synthesis
{
    public enum ArmorValue
    {
        NoArmor = 0,
        Armor250 = 250,
        Armor500 = 500
    }
    
    public class Config
    {
        [JsonProperty("Races")] public Dictionary<string, RaceData> Races = new();
    }
    
    public class RaceData
    {
        [JsonProperty("Keywords")] public List<string> Keywords { get; set; } = new();
        [JsonProperty("Armor")] public ArmorValue Armor { get; set; } = ArmorValue.NoArmor;
        
        [JsonProperty("Low Attacks")] public bool LowAttacks { get; set; }
        [JsonProperty("Remove Default Spell")] public bool RemoveSpell { get; set; }
        [JsonProperty("Add NPC Spell")] public bool AddSpell { get; set; }
        
        [JsonProperty("Base Mass")] public float BaseMass { get; set; } = float.NaN;
        
        [JsonProperty("Unarmed Damage")] public float UnarmedDamage { get; set; } = float.NaN;
        [JsonProperty("Unarmed Damage Multiplier")] public float UnarmedDamageMult { get; set; } = 1;
        [JsonProperty("Unarmed Reach")] public float UnarmedReach { get; set; } = float.NaN;
        
        [JsonProperty("Angular Acceleration")] public float AngularAcceleration { get; set; } = float.NaN;
        [JsonProperty("Angular Acceleration Hard")] public float AngularAccelerationHard { get; set; } = float.NaN;

        [JsonProperty("Attacks")] public Dictionary<string, Attack> Attacks { get; set; } = new();
    }

    public class Attack
    {
        [JsonProperty("Strike Angle")] public float StrikeAngle { get; set; } = float.NaN;
        [JsonProperty("Attack Angle")] public float AttackAngle { get; set; } = float.NaN;
        [JsonProperty("Attack Chance")] public float AttackChance { get; set; } = float.NaN;
        
        [JsonProperty("Damage Multiplier")] public float DamageMult { get; set; } = float.NaN;
        [JsonProperty("Damage Multiplier Increment")] public float DamageMultIncr { get; set; }

        [JsonProperty("Attack Flag")] public AttackData.Flag Flag { get; set; } = 0;
        [JsonProperty("Attack Type")] public string AttackType { get; set; } = "None";
        [JsonProperty("Attack Spell")] public string AttackSpell { get; set; } = "None";
    }
}