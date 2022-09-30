using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
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
            Name.Set(LanguageEnum.Deutsch, "Machterhöhung");
            Name.Set(LanguageEnum.English, "Raise power");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RaisePower());
        }
        #endregion
    }
}