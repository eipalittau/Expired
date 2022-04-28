using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Refining : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal Refining()
            : base(nameof(Refining), 300,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)),
                   null,
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Ring)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Amulet))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Veredeln");
            Name.Set(Util.LanguageEnum.English, "Refining");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}