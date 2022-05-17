using Exp.Data.Item.Effect;

namespace Exp.DefaultMod.Item.Effect {
    public sealed class Secondary : EffectDataBase, IEffectData {
        #region Konstruktor
        private Secondary()
            : base(nameof(Secondary), 200) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sekundär");
            Name.Set(Util.LanguageEnum.English, "Secondary");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Secondary());
        }
        #endregion
    }
}