using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class EfficientSmithing : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private EfficientSmithing()
            : base(nameof(EfficientSmithing), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Effizientes Schmieden");
            Name.Set(LanguageEnum.English, "Efficient smithing");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new EfficientSmithing());
        }
        #endregion
    }
}