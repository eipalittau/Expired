namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class Movement : Data.Player.LevelUpDataBase, Data.Player.ILevelUpData {
        #region Konstruktor
        private Movement()
            : base(Api.General.TargetEffectEnum.Movement, new Api.Helper.ModifierData(0, 0, 4)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bewegungsrate");
            Name.Set(Util.LanguageEnum.English, "Movement rate");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Movement());
        }
        #endregion
    }
}