using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Hardened : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Hardened()
            : base(nameof(Hardened), 400, true, false, 1, 0) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gehärtet");
            Name.Set(Util.LanguageEnum.English, "Hardened");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}