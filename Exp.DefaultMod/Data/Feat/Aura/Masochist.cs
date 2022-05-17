using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Masochist : AuraDataBase, IAuraData {
        #region Konstruktor
        private Masochist()
            : base(nameof(Masochist), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Masochist");
            Name.Set(Util.LanguageEnum.English, "Masochist");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Masochist());
        }
        #endregion
    }
}