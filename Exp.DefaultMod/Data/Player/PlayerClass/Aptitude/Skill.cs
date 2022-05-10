namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Skill : Exp.Data.Misc.AptitudeDataBase, Exp.Data.Misc.IAptitudeData {
        #region Konstruktor
        public Skill()
            : base(nameof(Skill), Api.General.CharacterChangerEnum.SkillPoints) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fertigkeit");
            Name.Set(Util.LanguageEnum.English, "Skill");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Anzahl der Fertigkeitspunkte pro Level um +1");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            Modifier.Intervall = 1;
            Modifier.Value = 1;
        }
        #endregion
    }
}