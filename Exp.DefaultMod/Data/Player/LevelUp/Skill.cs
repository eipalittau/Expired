namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class Skill : Data.Player.LevelUpDataBase, Data.Player.ILevelUpData {
        #region Konstruktor
        private Skill()
            : base(Api.General.TargetEffectEnum.SkillPoints, new Api.Helper.ModifierData(1, 0, 2)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fertigkeitspunkte");
            Name.Set(Util.LanguageEnum.English, "Skill points");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Skill());
        }
        #endregion
    }
}