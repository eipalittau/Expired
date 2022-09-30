using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class InefficientSmithing : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private InefficientSmithing()
            : base(nameof(InefficientSmithing), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Ineffizientes Schmieden");
            Name.Set(LanguageEnum.English, "Inefficient smithing");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new InefficientSmithing());
        }
        #endregion
    }
}