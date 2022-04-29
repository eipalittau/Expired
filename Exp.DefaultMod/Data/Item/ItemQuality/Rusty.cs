using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Rusty : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Rusty()
            : base(nameof(Rusty), 100, true, false, -1, -1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rostig");
            Name.Set(Util.LanguageEnum.English, "Rusty");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}