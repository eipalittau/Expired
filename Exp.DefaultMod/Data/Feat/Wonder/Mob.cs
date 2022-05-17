using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class Mob : WonderDataBase, IWonderData {
        #region Konstruktor
        private Mob()
            : base(nameof(Mob), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Horde");
            Name.Set(Util.LanguageEnum.English, "Mob");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mob());
        }
        #endregion
    }
}