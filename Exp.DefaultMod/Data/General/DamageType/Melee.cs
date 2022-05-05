namespace Exp.DefaultMod.General.DamageType {
    public sealed class Melee : Exp.Data.General.DamageTypeBase, Exp.Data.General.IDamageTypeData {
        #region Konstruktor
        private Melee()
            : base(nameof(Melee), 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nahkampf");
            Name.Set(Util.LanguageEnum.English, "Melee");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Melee());
        }
        #endregion
    }
}