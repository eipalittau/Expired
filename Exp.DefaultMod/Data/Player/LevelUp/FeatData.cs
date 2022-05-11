namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class FeatData : Exp.Data.Player.LevelUpDataBase, Exp.Data.Player.ILevelUpData {
        #region Konstruktor
        private FeatData()
            : base(Api.General.CharacterChangerEnum.FeatPoints, new Exp.Data.Misc.ModifierData(1, 1)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Attributspunkte");
            Name.Set(Util.LanguageEnum.English, "Feat points");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new FeatData());
        }
        #endregion
    }
}