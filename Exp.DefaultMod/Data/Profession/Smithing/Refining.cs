using Exp.Data.Profession.Smithing;

namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class Refining : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private Refining()
            : base(nameof(Refining), 300,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Ring)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Amulet))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Veredeln");
            Name.Set(Util.LanguageEnum.English, "Refining");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Refining());
        }
        #endregion
    }
}