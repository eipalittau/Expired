using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Perfection : AuraDataBase, IAuraData {
        #region Konstruktor
        private Perfection()
            : base(nameof(Perfection), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Perfektion");
            Name.Set(LanguageEnum.English, "Perfection");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Perfection());
        }
        #endregion
    }
}