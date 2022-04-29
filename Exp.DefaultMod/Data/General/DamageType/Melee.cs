namespace Exp.DefaultMod.General.DamageType {
    public sealed class Melee : DamageTypeBase, Data.General.IDamageTypeData {
        #region Konstruktor
        internal Melee()
            : base(nameof(Melee), 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nahkampf");
            Name.Set(Util.LanguageEnum.English, "Melee");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}
