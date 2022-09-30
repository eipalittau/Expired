using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class ElementalArmor : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private ElementalArmor()
            : base(nameof(ElementalArmor), 1000,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Profession.Smithing.Singleton.Get(nameof(Hardening)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Shield)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bracers)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Headgear))) {
            Name.Set(LanguageEnum.Deutsch, "Elementarrüstung");
            Name.Set(LanguageEnum.English, "Elemental armor");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ElementalArmor());
        }
        #endregion
    }
}