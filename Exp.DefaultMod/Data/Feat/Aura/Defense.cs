using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Defense : AuraDataBase, IAuraData {
        #region Konstruktor
        private Defense()
            : base(nameof(Defense), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Aura der Verteidigung");
            Name.Set(LanguageEnum.English, "Aura of defense");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Defense());
        }
        #endregion
    }
}