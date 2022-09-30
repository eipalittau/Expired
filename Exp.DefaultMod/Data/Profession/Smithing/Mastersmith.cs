using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class Mastersmith : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private Mastersmith()
            : base(nameof(Mastersmith), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Meisterschmied");
            Name.Set(LanguageEnum.English, "Mastersmith");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mastersmith());
        }
        #endregion
    }
}