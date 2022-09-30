using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Fencer : AuraDataBase, IAuraData {
        #region Konstruktor
        private Fencer()
            : base(nameof(Fencer), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Aura des Fechters");
            Name.Set(LanguageEnum.English, "Aura of the fencer");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fencer());
        }
        #endregion
    }
}