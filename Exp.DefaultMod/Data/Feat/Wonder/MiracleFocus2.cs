using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class MiracleFocus2 : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiracleFocus2()
            : base(nameof(MiracleFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wonder.Singleton.Get(nameof(MiracleFocus))) {
            Name.Set(LanguageEnum.Deutsch, "Wunderfokus++");
            Name.Set(LanguageEnum.English, "Miracle focus++");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiracleFocus2());
        }
        #endregion
    }
}