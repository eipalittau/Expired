using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class Enlarge : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private Enlarge()
            : base(nameof(Enlarge), 1100,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Profession.Smithing.Singleton.Get(nameof(Refining)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Ring))) {
            Name.Set(LanguageEnum.Deutsch, "Vergrössern");
            Name.Set(LanguageEnum.English, "Enlarge");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Enlarge());
        }
        #endregion
    }
}