using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Sadist : AuraDataBase, IAuraData {
        #region Konstruktor
        private Sadist()
            : base(nameof(Sadist), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Sadist");
            Name.Set(LanguageEnum.English, "Sadist");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Sadist());
        }
        #endregion
    }
}