using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Perfection : AuraDataBase, IAuraData {
        #region Konstruktor
        private Perfection()
            : base(nameof(Perfection), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Perfektion");
            Name.Set(Util.LanguageEnum.English, "Perfection");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Perfection());
        }
        #endregion
    }
}