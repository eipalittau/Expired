using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class MiraculousPower : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiraculousPower()
            : base(nameof(MiraculousPower), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Wundermacht");
            Name.Set(LanguageEnum.English, "Miraculous power");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiraculousPower());
        }
        #endregion
    }
}