using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Masochist : AuraDataBase, IAuraData {
        #region Konstruktor
        private Masochist()
            : base(nameof(Masochist), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Masochist");
            Name.Set(LanguageEnum.English, "Masochist");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Masochist());
        }
        #endregion
    }
}