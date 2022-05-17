using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class MiracleFocus : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiracleFocus()
            : base(nameof(MiracleFocus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderfokus");
            Name.Set(Util.LanguageEnum.English, "Miracle focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiracleFocus());
        }
        #endregion
    }
}