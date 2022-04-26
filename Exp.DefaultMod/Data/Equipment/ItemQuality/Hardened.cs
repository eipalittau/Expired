using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemQuality {
    internal sealed class Hardened : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Hardened()
            : base(nameof(Hardened), 400, true, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gehärtet");
            Name.Set(Util.LanguageEnum.English, "Hardened");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}