using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Sadist : AuraDataBase, IAuraData {
        #region Konstruktor
        private Sadist()
            : base(nameof(Sadist), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sadist");
            Name.Set(Util.LanguageEnum.English, "Sadist");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Sadist());
        }
        #endregion
    }
}