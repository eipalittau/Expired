using Exp.Data.Item;

namespace Exp.DefaultMod.Item.Effect {
    internal sealed class Primary : EffectDataBase, IEffectData {
        #region Konstruktor
        internal Primary()
            : base(nameof(Primary), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Primär");
            Name.Set(Util.LanguageEnum.English, "Primary");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}