using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class MiraculousPower2 : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiraculousPower2()
            : base(nameof(MiraculousPower2), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wonder.Singleton.Get(nameof(MiraculousPower))) {
            Name.Set(LanguageEnum.Deutsch, "Wundermacht++");
            Name.Set(LanguageEnum.English, "Miraculous power++");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiraculousPower2());
        }
        #endregion
    }
}