using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class Power : AuraDataBase, IAuraData {
        #region Konstruktor
        private Power()
            : base(nameof(Power), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Aura der Macht");
            Name.Set(LanguageEnum.English, "Aura of power");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Power());
        }
        #endregion
    }
}