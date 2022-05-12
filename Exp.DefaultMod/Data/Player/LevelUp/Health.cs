namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class Health : Data.Player.LevelUpDataBase, Data.Player.ILevelUpData {
        #region Konstruktor
        private Health()
            : base(Api.General.TargetEffectEnum.Health, new Api.Helper.ModifierData(1, 0, 4)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fertigkeitspunkte");
            Name.Set(Util.LanguageEnum.English, "Skill points");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Health());
        }
        #endregion
    }
}