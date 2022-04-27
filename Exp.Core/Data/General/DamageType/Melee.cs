namespace Exp.Data.General.DamageType {
    public sealed class Melee : DamageTypeBase, IDamageTypeData {
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
