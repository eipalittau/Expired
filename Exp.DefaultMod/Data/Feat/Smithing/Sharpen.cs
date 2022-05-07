namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class Sharpen : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
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
            Name.Set(Util.LanguageEnum.Deutsch, "Schärfen");
            Name.Set(Util.LanguageEnum.English, "Sharpen");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Sharpen());
        }
        #endregion
    }
}