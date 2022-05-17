using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Focus : AuraDataBase, IAuraData {
        #region Konstruktor
        private Focus()
            : base(nameof(Focus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fokus");
            Name.Set(Util.LanguageEnum.English, "Focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Focus());
        }
        #endregion
    }
}