using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Enhanced : AuraDataBase, IAuraData {
        #region Konstruktor
        private Enhanced()
            : base(nameof(Enhanced), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Verstärkte Aura");
            Name.Set(LanguageEnum.English, "Enhanced aura");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Enhanced());
        }
        #endregion
    }
}