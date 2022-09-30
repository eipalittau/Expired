using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class Refining : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private Refining()
            : base(nameof(Refining), 300,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Ring)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Amulet))) {
            Name.Set(LanguageEnum.Deutsch, "Veredeln");
            Name.Set(LanguageEnum.English, "Refining");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Refining());
        }
        #endregion
    }
}