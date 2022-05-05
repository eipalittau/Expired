namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class Enlarge : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
        #region Konstruktor
        private Enlarge()
            : base(nameof(Enlarge), 1100,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Feat.Smithing.Singleton.Get(nameof(Refining)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Ring))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Vergrössern");
            Name.Set(Util.LanguageEnum.English, "Enlarge");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Enlarge());
        }
        #endregion
    }
}