using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class ThingT : WonderDataBase, IWonderData {
        #region Konstruktor
        private ThingT()
            : base(nameof(ThingT), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Eiskaltes Händchen");
            Name.Set(LanguageEnum.English, "ThingT"); //Englische Übersetzung aus "Addams Family"
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ThingT());
        }
        #endregion
    }
}