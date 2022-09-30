using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class DiamondArmor : WonderDataBase, IWonderData {
        #region Konstruktor
        private DiamondArmor()
            : base(nameof(DiamondArmor), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Diamantrüstung");
            Name.Set(LanguageEnum.English, "Diamond armor");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DiamondArmor());
        }
        #endregion
    }
}