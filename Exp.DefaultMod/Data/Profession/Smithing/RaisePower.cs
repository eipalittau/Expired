using Exp.Data.Profession.Smithing;

namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class RaisePower : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private RaisePower()
            : base(nameof(RaisePower), 400,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Ring)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Amulet)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Focus)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Grimoire)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Cape)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Headgear)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bracers)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Machterhöhung");
            Name.Set(Util.LanguageEnum.English, "Raise power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RaisePower());
        }
        #endregion
    }
}