using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Defense : AuraDataBase, IAuraData {
        #region Konstruktor
        private Defense()
            : base(nameof(Defense), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Verteidigung");
            Name.Set(Util.LanguageEnum.English, "Aura of defense");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Defense());
        }
        #endregion
    }
}