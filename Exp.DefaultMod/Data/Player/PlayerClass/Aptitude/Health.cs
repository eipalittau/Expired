namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Health : Exp.Data.Misc.AptitudeDataBase, Exp.Data.Misc.IAptitudeData {
        #region Konstruktor
        public Health()
            : base(nameof(Health), Api.General.CharacterChangerEnum.Health) {
            Name.Set(Util.LanguageEnum.Deutsch, "Lebenspunkt");
            Name.Set(Util.LanguageEnum.English, "Health");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Anzahl Lebenspunkte pro Level um +2");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            Modifier.Intervall = 1;
            Modifier.Value = 2;
        }
        #endregion
    }
}