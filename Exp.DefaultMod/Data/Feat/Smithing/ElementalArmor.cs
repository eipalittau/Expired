using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class ElementalArmor : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal ElementalArmor()
            : base(nameof(ElementalArmor), 1000,
                   Api.General.Tier.Singleton.Get(nameof(Exp.Data.General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(Hardening)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Armor)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Boots)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Shield)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bracers)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Headgear))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Elementarrüstung");
            Name.Set(Util.LanguageEnum.English, "Elemental armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}