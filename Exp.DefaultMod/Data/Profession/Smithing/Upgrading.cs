using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class Upgrading : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private Upgrading()
            : base(nameof(Upgrading), 600,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
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
            Name.Set(LanguageEnum.Deutsch, "Aufwertung");
            Name.Set(LanguageEnum.English, "Upgrading");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Upgrading());
        }
        #endregion
    }
}