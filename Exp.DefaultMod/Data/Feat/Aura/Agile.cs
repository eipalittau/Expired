using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Agile : AuraDataBase, IAuraData {
        #region Konstruktor
        private Agile()
            : base(nameof(Agile), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Geschickt");
            Name.Set(LanguageEnum.English, "Agile");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Agile());
        }
        #endregion
    }
}