using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Power : AuraDataBase, IAuraData {
        #region Konstruktor
        private Power()
            : base(nameof(Power), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Macht");
            Name.Set(Util.LanguageEnum.English, "Aura of power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Power());
        }
        #endregion
    }
}