using Exp.Data.General.DamageType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DamageType
{
    public sealed class Melee : DamageTypeBase, IDamageTypeData {
        #region Konstruktor
        private Melee()
            : base(nameof(Melee), 1) {
            Name.Set(LanguageEnum.Deutsch, "Nahkampf");
            Name.Set(LanguageEnum.English, "Melee");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Melee());
        }
        #endregion
    }
}