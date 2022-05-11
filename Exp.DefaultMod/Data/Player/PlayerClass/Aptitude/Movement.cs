namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Movement : Exp.Data.Misc.AptitudeDataBase, Exp.Data.Misc.IAptitudeData {
        #region Konstruktor
        public Movement()
            : base(nameof(Movement), Api.General.CharacterChangerEnum.Movement) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bewegungsrate");
            Name.Set(Util.LanguageEnum.English, "Movement");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Bewegungsrate um +1 Feld pro 2 Level");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            Modifier.Intervall = 2;
            Modifier.Value = 1;
        }
        #endregion
    }
}