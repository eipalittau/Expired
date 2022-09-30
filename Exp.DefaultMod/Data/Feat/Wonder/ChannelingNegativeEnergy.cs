using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class ChannelingNegativeEnergy : WonderDataBase, IWonderData {
        #region Konstruktor
        private ChannelingNegativeEnergy()
            : base(nameof(ChannelingNegativeEnergy), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Negative Energie Kanalisieren");
            Name.Set(LanguageEnum.English, "Channeling negative energy");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ChannelingNegativeEnergy());
        }
        #endregion
    }
}