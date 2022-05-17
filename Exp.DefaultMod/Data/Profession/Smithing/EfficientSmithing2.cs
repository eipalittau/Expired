using Exp.Data.Profession.Smithing;

namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class EfficientSmithing2 : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private EfficientSmithing2()
            : base(nameof(EfficientSmithing2), 1300,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Profession.Smithing.Singleton.Get(nameof(EfficientSmithing))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sehr effizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Very efficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new EfficientSmithing2());
        }
        #endregion
    }
}