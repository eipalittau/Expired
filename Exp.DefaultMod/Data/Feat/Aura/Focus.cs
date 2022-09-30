using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Focus : AuraDataBase, IAuraData {
        #region Konstruktor
        private Focus()
            : base(nameof(Focus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Fokus");
            Name.Set(LanguageEnum.English, "Focus");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Focus());
        }
        #endregion
    }
}