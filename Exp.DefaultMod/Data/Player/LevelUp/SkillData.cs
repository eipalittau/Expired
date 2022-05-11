namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class SkillData : Exp.Data.Player.LevelUpDataBase, Exp.Data.Player.ILevelUpData {
        #region Konstruktor
        private SkillData()
            : base(Api.General.CharacterChangerEnum.SkillPoints, new Exp.Data.Misc.ModifierData(1, 2)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fertigkeitspunkte");
            Name.Set(Util.LanguageEnum.English, "Skill points");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SkillData());
        }
        #endregion
    }
}