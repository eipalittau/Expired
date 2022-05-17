using Exp.Data.Profession.Smithing;

namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class InefficientSmithing2 : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private InefficientSmithing2()
            : base(nameof(InefficientSmithing2), 1200,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Profession.Smithing.Singleton.Get(nameof(InefficientSmithing))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sehr ineffizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Very inefficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new InefficientSmithing2());
        }
        #endregion
    }
}