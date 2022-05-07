namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class AccurateWeapon : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private AccurateWeapon()
            : base(nameof(AccurateWeapon), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zielsichere Waffe");
            Name.Set(Util.LanguageEnum.English, "Accurate weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new AccurateWeapon());
        }
        #endregion
    }
}