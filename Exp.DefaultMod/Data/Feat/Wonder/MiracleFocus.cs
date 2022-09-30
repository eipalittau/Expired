using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class MiracleFocus : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiracleFocus()
            : base(nameof(MiracleFocus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Wunderfokus");
            Name.Set(LanguageEnum.English, "Miracle focus");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiracleFocus());
        }
        #endregion
    }
}