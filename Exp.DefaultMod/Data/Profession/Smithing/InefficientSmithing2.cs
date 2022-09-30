using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class InefficientSmithing2 : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private InefficientSmithing2()
            : base(nameof(InefficientSmithing2), 1200,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Profession.Smithing.Singleton.Get(nameof(InefficientSmithing))) {
            Name.Set(LanguageEnum.Deutsch, "Sehr ineffizientes Schmieden");
            Name.Set(LanguageEnum.English, "Very inefficient smithing");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new InefficientSmithing2());
        }
        #endregion
    }
}