using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Fencer : AuraDataBase, IAuraData {
        #region Konstruktor
        private Fencer()
            : base(nameof(Fencer), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Fechters");
            Name.Set(Util.LanguageEnum.English, "Aura of the fencer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fencer());
        }
        #endregion
    }
}