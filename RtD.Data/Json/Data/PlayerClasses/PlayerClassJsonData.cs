namespace RtD.Data.Json.PlayerClass { // Json/Data/PlayerClasses
    internal sealed class PlayerClassJsonData : JsonDataBase {
        public string? CharacterName { get; set; }
        public ArmorClassJsonData? ArmorClass { get; set; }
        public HealthJsonData? Health { get; set; }
        public SkillJsonData? Skill { get; set; }
        public HealJsonData? Heal { get; set; }
        public string? Mechanism { get; set; }
        public WizardryLevelJsonData? WizardryLevel { get; set; }
        public WonderLevelJsonData? WonderLevel { get; set; }
    }
}