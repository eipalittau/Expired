using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Enlarge : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal Enlarge()
            : base(nameof(Enlarge), 1100,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(Refining)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Ring))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Vergrössern");
            Name.Set(Util.LanguageEnum.English, "Enlarge");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}