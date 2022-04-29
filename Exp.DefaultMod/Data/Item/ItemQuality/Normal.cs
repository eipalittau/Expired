using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Normal : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Normal()
            : base(nameof(Normal), 300, true, true, 0, 0) {
            Name.Set(Util.LanguageEnum.Deutsch, "Normal");
            Name.Set(Util.LanguageEnum.English, "Normal");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}