using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class IceArmor : WonderDataBase, IWonderData {
        #region Konstruktor
        private IceArmor()
            : base(nameof(IceArmor), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eisrüstung");
            Name.Set(Util.LanguageEnum.English, "Ice armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new IceArmor());
        }
        #endregion
    }
}