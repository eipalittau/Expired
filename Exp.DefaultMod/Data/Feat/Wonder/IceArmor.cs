using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class IceArmor : WonderDataBase, IWonderData {
        #region Konstruktor
        private IceArmor()
            : base(nameof(IceArmor), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Eisrüstung");
            Name.Set(LanguageEnum.English, "Ice armor");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new IceArmor());
        }
        #endregion
    }
}