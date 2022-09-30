using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Anger : AuraDataBase, IAuraData {
        #region Konstruktor
        private Anger()
            : base(nameof(Anger), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.Feat.Aura.Singleton.Get(nameof(Fencer)), Api.Feat.Aura.Singleton.Get(nameof(Power))) {
            Name.Set(LanguageEnum.Deutsch, "Aura des Zorns");
            Name.Set(LanguageEnum.English, "Aura of anger");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Anger());
        }
        #endregion
    }
}