namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class MagicWeapon : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private MagicWeapon()
            : base(nameof(MagicWeapon), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magische Waffe");
            Name.Set(Util.LanguageEnum.English, "Magic weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicWeapon());
        }
        #endregion
    }
}