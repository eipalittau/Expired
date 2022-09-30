using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class Brains : WonderDataBase, IWonderData {
        #region Konstruktor
        private Brains()
            : base(nameof(Brains), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Full))) {
            Name.Set(LanguageEnum.Deutsch, "BRAINZZZZ!");
            Name.Set(LanguageEnum.English, "BRAINZZZZ!");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Brains());
        }
        #endregion
    }
}