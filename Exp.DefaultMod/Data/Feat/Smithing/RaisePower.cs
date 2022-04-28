using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class RaisePower : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal RaisePower()
            : base(nameof(RaisePower), 400,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)),
                   null,
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Ring)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Amulet)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Focus)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Grimoire)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Cape)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Headgear)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bracers)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Boots)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Armor))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Machterhöhung");
            Name.Set(Util.LanguageEnum.English, "Raise power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}