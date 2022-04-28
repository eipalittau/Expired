using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class ElementalDamage : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal ElementalDamage()
            : base(nameof(ElementalDamage), 900,
                   Api.General.Tier.Singleton.Get(nameof(Exp.Data.General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(Sharpen)),
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
            Name.Set(Util.LanguageEnum.Deutsch, "Elementarschaden");
            Name.Set(Util.LanguageEnum.English, "Elemental damage");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}