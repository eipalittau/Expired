using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Flatulence : AuraDataBase, IAuraData {
        #region Konstruktor
        private Flatulence()
            : base(nameof(Flatulence), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Blähungen");
            Name.Set(Util.LanguageEnum.English, "Flatulence");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Flatulence());
        }
        #endregion
    }
}