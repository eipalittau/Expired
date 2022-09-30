using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class MiracleDoll : WonderDataBase, IWonderData {
        #region Konstruktor
        private MiracleDoll()
            : base(nameof(MiracleDoll), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Wunderpuppe");
            Name.Set(LanguageEnum.English, "Miracle doll");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MiracleDoll());
        }
        #endregion
    }
}