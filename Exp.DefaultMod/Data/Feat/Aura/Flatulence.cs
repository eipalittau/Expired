using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Flatulence : AuraDataBase, IAuraData {
        #region Konstruktor
        private Flatulence()
            : base(nameof(Flatulence), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Blähungen");
            Name.Set(LanguageEnum.English, "Flatulence");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Flatulence());
        }
        #endregion
    }
}