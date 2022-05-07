namespace Exp.DefaultMod.Item.Effect {
    public sealed class Primary : Exp.Data.Item.EffectDataBase, Exp.Data.Item.IEffectData {
        #region Konstruktor
        private Primary()
            : base(nameof(Primary), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Primär");
            Name.Set(Util.LanguageEnum.English, "Primary");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Primary());
        }
        #endregion
    }
}