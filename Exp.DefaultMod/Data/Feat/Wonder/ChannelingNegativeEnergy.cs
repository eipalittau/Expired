using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class ChannelingNegativeEnergy : WonderDataBase, IWonderData {
        #region Konstruktor
        private ChannelingNegativeEnergy()
            : base(nameof(ChannelingNegativeEnergy), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Negative Energie Kanalisieren");
            Name.Set(Util.LanguageEnum.English, "Channeling negative energy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ChannelingNegativeEnergy());
        }
        #endregion
    }
}