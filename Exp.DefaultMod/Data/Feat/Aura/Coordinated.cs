using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Coordinated : AuraDataBase, IAuraData {
        #region Konstruktor
        private Coordinated()
            : base(nameof(Coordinated), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Koordiniert");
            Name.Set(LanguageEnum.English, "Coordinated");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Coordinated());
        }
        #endregion
    }
}