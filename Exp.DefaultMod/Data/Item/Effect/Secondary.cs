using Exp.Data.Item;

namespace Exp.DefaultMod.Item.Effect {
    internal sealed class Secondary : EffectDataBase, IEffectData {
        #region Konstruktor
        internal Secondary()
            : base(nameof(Secondary), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sekundär");
            Name.Set(Util.LanguageEnum.English, "Secondary");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}