using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Interdisciplinary : AuraDataBase, IAuraData {
        #region Konstruktor
        private Interdisciplinary()
            : base(nameof(Interdisciplinary), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Interdisziplinär");
            Name.Set(LanguageEnum.English, "Interdisciplinary");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Interdisciplinary());
        }
        #endregion
    }
}