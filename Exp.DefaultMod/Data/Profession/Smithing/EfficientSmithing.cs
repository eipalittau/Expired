using Exp.Data.Profession.Smithing;

namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class EfficientSmithing : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private EfficientSmithing()
            : base(nameof(EfficientSmithing), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Effizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Efficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new EfficientSmithing());
        }
        #endregion
    }
}