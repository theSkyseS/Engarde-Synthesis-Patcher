using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Engarde_Synthesis
{
    public class Config
    {
        [JsonProperty("behaviour")]
        public string Behaviour { get; set; } = string.Empty;

        [JsonProperty("RaceData")]
        public Dictionary<string, RaceData> RaceData { get; set; } = new();
    }

    public class RaceData
    {
        [JsonProperty("Unarmed Reach")] public float UnarmedReach { get; set; } = float.MaxValue;
        [JsonProperty("Angular Acceleration")] public float AngularAcceleration { get; set; } = float.MaxValue;
        [JsonProperty("Angle Tolerance")] public float AngleTolerance { get; set; } = float.MaxValue;

        [JsonProperty("Attacks")]
        public Dictionary<string, Attack> Attacks { get; set; } = new Dictionary<string, Attack>();
    }

    public class Attack
    {
        [JsonProperty("Strike Angle")] public float StrikeAngle { get; set; } = float.MaxValue;
        [JsonProperty("Attack Angle")] public float AttackAngle { get; set; } = float.MaxValue;
    }
}