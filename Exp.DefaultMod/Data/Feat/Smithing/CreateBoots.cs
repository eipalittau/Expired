using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class CreateBoots : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal CreateBoots()
            : base(nameof(CreateBoots), 500,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)),
                   null,
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Boots))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schiefel schmieden");
            Name.Set(Util.LanguageEnum.English, "Create boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}