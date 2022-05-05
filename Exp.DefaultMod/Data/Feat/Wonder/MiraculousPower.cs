namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class MiraculousPower : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private MiraculousPower()
            : base(nameof(MiraculousPower), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wundermacht");
            Name.Set(Util.LanguageEnum.English, "Miraculous power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiraculousPower());
        }
        #endregion
    }
}