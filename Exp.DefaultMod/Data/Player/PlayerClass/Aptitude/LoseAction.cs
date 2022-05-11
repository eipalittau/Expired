namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class LoseAction : Exp.Data.Misc.AptitudeDataBase, Exp.Data.Misc.IAptitudeData {
        #region Konstruktor
        public LoseAction()
            : base(nameof(LoseAction), Api.General.CharacterChangerEnum.Feat) {
            Name.Set(Util.LanguageEnum.Deutsch, "xx");
            Name.Set(Util.LanguageEnum.English, "yy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "xxx");
            LoreDescription.Set(Util.LanguageEnum.English, "yyy");
            Modifier.Intervall = 1;
            Modifier.Value = 2;
        }
        #endregion
    }
}