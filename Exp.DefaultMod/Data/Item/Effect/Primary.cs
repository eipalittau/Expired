using Exp.Data.Item.Effect;

namespace Exp.DefaultMod.Item.Effect {
    public sealed class Primary : EffectDataBase, IEffectData {
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