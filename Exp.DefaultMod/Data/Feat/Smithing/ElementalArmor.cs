namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class ElementalArmor : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
        #region Konstruktor
        private ElementalArmor()
            : base(nameof(ElementalArmor), 1000,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(Hardening)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Shield)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bracers)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Headgear))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Elementarrüstung");
            Name.Set(Util.LanguageEnum.English, "Elemental armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ElementalArmor());
        }
        #endregion
    }
}