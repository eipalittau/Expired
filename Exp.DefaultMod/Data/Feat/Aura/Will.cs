using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Will : AuraDataBase, IAuraData {
        #region Konstruktor
        private Will()
            : base(nameof(Will), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Aura des Willens");
            Name.Set(LanguageEnum.English, "Aura of will");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Will());
        }
        #endregion
    }
}