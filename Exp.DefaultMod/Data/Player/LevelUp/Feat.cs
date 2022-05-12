namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class Feat : Data.Player.LevelUpDataBase, Data.Player.ILevelUpData {
        #region Konstruktor
        private Feat()
            : base(Api.General.TargetEffectEnum.FeatPoints, new Api.Helper.ModifierData(1, 0, 1)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Attributspunkte");
            Name.Set(Util.LanguageEnum.English, "Feat points");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Feat());
        }
        #endregion
    }
}