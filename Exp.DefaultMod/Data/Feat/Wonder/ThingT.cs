using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class ThingT : WonderDataBase, IWonderData {
        #region Konstruktor
        private ThingT()
            : base(nameof(ThingT), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eiskaltes Händchen");
            Name.Set(Util.LanguageEnum.English, "ThingT"); //Englische Übersetzung aus "Addams Family"
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ThingT());
        }
        #endregion
    }
}