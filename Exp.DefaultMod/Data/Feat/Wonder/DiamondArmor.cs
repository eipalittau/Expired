namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class DiamondArmor : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private DiamondArmor()
            : base(nameof(DiamondArmor), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Diamantrüstung");
            Name.Set(Util.LanguageEnum.English, "Diamond armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DiamondArmor());
        }
        #endregion
    }
}