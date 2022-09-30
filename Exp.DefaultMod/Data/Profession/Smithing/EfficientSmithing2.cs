using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class EfficientSmithing2 : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private EfficientSmithing2()
            : base(nameof(EfficientSmithing2), 1300,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)),
                   Api.Profession.Smithing.Singleton.Get(nameof(EfficientSmithing))) {
            Name.Set(LanguageEnum.Deutsch, "Sehr effizientes Schmieden");
            Name.Set(LanguageEnum.English, "Very efficient smithing");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new EfficientSmithing2());
        }
        #endregion
    }
}