﻿namespace Exp.Api.Player {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        public Util.LanguageEnum Language { get; private set; }
        public Data.Player.IPlayerClassData PlayerClass { get; init; }
        public Sheet.FeatData Feat { get; init; }
        public List<Sheet.SkillData> SkillList { get; } = new List<Sheet.SkillData>();
        public List<Sheet.EquipmentData> EquipmentList { get; } = new List<Sheet.EquipmentData>();
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.IPlayerClassData aPlayerClass, Util.LanguageEnum aLanguage) { 
            PlayerClass = aPlayerClass;
            Language = aLanguage;
            Feat = new Sheet.FeatData();
            Skill.SkillGroup.Singleton.Enumerate().ToList().ForEach(x => SkillList.Add(new Sheet.SkillData(x)));
            Slot.Singleton.Enumerate().Where(x => x.Available).ToList().ForEach(x => EquipmentList.Add(new Sheet.EquipmentData(x)));
        }
        #endregion

        #region Methoden
        public static CharacterSheet Create(Util.LanguageEnum aLanguage) {
            Data.General.IDiceTypeData lDice = General.DiceType.Singleton.Get(Player.PlayerClass.Singleton.Count());
            
            return Create(Player.PlayerClass.Singleton.Enumerate().ElementAt(lDice.Roll()), aLanguage);
        }

        public static CharacterSheet Create(Data.Player.IPlayerClassData aPlayerClass, Util.LanguageEnum aLanguage) {
            CharacterSheet lNew = new(aPlayerClass, aLanguage);

            return lNew;
        }

        public void SetLanguage(Util.LanguageEnum aLanguage) {
            Language = aLanguage;
        }
        #endregion
    }
}