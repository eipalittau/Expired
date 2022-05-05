namespace Exp.Api.Player {
    public sealed class CharacterSheet : Data.Player.ICharacterSheetData {
        #region Properties / Felder
        #region General
        public Util.LanguageEnum Language { get; set; }
        #endregion

        #region PlayerClass
        public string CharacterName { 
            get {
                return PlayerClass.CharacterName;
            }
        }
        public string CharacterDescription {
            get {
                return PlayerClass.LoreDescription.Get(Language);
            }
        }
        public string CharacterClass {
            get {
                return PlayerClass.Name.Get(Language);
            }
        }
        private Data.Player.IPlayerClassData PlayerClass { get; init; }
        #endregion

        public Sheet.FeatData Feat { get; init; }
        #endregion

        #region Konstruktor
        private CharacterSheet(Data.Player.IPlayerClassData aPlayerClass, Util.LanguageEnum aLanguage) { 
            PlayerClass = aPlayerClass;
            Language = aLanguage;
            Feat = new Sheet.FeatData();
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
        #endregion
    }
}