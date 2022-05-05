namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class ElementalDamage : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
        #region Konstruktor
        private ElementalDamage()
            : base(nameof(ElementalDamage), 900,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(Sharpen)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.OneHandedWeapon)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.TwoHandedWeapon)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bow)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Crossbow)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Arrow)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bolt)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Dagger)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Shield)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bracers)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Headgear))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Elementarschaden");
            Name.Set(Util.LanguageEnum.English, "Elemental damage");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }

        #region Methoden
        public static void Add() {
            AddInstance(new ElementalDamage());
        }
        #endregion
        #endregion
    }
}