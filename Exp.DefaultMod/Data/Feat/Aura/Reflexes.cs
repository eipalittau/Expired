using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Reflexes : AuraDataBase, IAuraData {
        #region Konstruktor
        private Reflexes()
            : base(nameof(Reflexes), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Aura der Reflexe");
            Name.Set(LanguageEnum.English, "Aura of reflexes");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Reflexes());
        }
        #endregion
    }
}