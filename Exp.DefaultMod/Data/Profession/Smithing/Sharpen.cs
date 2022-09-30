using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class Sharpen : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private Sharpen()
            : base(nameof(Sharpen), 100, 
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), 
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.OneHandedWeapon)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.TwoHandedWeapon)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bow)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Crossbow)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Arrow)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bolt)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Dagger))) {
            Name.Set(LanguageEnum.Deutsch, "Schärfen");
            Name.Set(LanguageEnum.English, "Sharpen");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Sharpen());
        }
        #endregion
    }
}