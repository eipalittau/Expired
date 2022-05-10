namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class ArmorClass : Exp.Data.Misc.AptitudeDataBase, Exp.Data.Misc.IAptitudeData {
        #region Konstruktor
        public ArmorClass()
            : base(nameof(ArmorClass), Api.General.CharacterChangerEnum.Armor) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rüstung");
            Name.Set(Util.LanguageEnum.English, "Armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Anzahl der Rüstungspunkte um +2");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            Modifier.Intervall = 0;
            Modifier.Value = 2;
        }
        #endregion
    }
}