namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Mana : Exp.Data.Misc.AptitudeDataBase, Exp.Data.Misc.IAptitudeData {
        #region Konstruktor
        public Mana()
            : base(nameof(Mana), Api.General.CharacterChangerEnum.Mana) {
            Name.Set(Util.LanguageEnum.Deutsch, "Mana");
            Name.Set(Util.LanguageEnum.English, "Mana");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Manapunkte um +1");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            Modifier.Intervall = 0;
            Modifier.Value = 1;
        }
        #endregion
    }
}