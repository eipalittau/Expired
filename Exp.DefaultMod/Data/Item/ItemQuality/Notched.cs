using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Notched : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Notched()
            : base(nameof(Notched), 200, true, false, -1, 0) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schartig");
            Name.Set(Util.LanguageEnum.English, "Notched");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}