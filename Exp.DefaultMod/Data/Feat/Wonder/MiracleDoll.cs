using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class MiracleDoll : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiracleDoll()
            : base(nameof(MiracleDoll), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderpuppe");
            Name.Set(Util.LanguageEnum.English, "Miracle doll");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiracleDoll());
        }
        #endregion
    }
}