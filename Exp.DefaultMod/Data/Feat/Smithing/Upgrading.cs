using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Upgrading : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal Upgrading()
            : base(nameof(Upgrading), 600,
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)),
                   null,
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.OneHandedWeapon)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.TwoHandedWeapon)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bow)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Crossbow)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Arrows)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bolt)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Dagger)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Armor)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Boots)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Shield)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bracers)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Headgear))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aufwertung");
            Name.Set(Util.LanguageEnum.English, "Upgrading");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}