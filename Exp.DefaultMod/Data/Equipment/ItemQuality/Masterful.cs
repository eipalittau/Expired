using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemQuality {
    internal sealed class Masterful : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Masterful()
            : base(nameof(Masterful), 500, false, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Meisterhaft");
            Name.Set(Util.LanguageEnum.English, "Masterful");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}