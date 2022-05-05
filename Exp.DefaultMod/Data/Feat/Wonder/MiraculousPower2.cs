namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class MiraculousPower2 : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private MiraculousPower2()
            : base(nameof(MiraculousPower2), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wonder.Singleton.Get(nameof(MiraculousPower))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wundermacht++");
            Name.Set(Util.LanguageEnum.English, "Miraculous power++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiraculousPower2());
        }
        #endregion
    }
}