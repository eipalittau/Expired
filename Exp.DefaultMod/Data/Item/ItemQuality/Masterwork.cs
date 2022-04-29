using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Masterwork : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Masterwork()
            : base(nameof(Masterwork), 500, false, false, 1, 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Meisterarbeit");
            Name.Set(Util.LanguageEnum.English, "Masterwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}