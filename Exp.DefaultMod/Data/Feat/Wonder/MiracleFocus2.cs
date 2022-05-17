using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class MiracleFocus2 : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiracleFocus2()
            : base(nameof(MiracleFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wonder.Singleton.Get(nameof(MiracleFocus))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderfokus++");
            Name.Set(Util.LanguageEnum.English, "Miracle focus++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiracleFocus2());
        }
        #endregion
    }
}