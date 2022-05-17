using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Interdisciplinary : AuraDataBase, IAuraData {
        #region Konstruktor
        private Interdisciplinary()
            : base(nameof(Interdisciplinary), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Interdisziplinär");
            Name.Set(Util.LanguageEnum.English, "Interdisciplinary");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Interdisciplinary());
        }
        #endregion
    }
}