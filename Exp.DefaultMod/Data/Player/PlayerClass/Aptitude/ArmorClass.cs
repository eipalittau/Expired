using Exp.Data.Misc.Aptitude;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude
{
    public sealed class ArmorClass : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public ArmorClass()
            : base(nameof(ArmorClass), Api.General.TargetEffectEnum.Armor) {
            base.Name.Set(LanguageEnum.Deutsch, "Rüstung");
            base.Name.Set(LanguageEnum.English, "Armor");
            base.LoreDescription.Set(LanguageEnum.Deutsch, "Ändert die Anzahl der Rüstungspunkte um +2");
            base.LoreDescription.Set(LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(0, 0, 2);
            
            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, false, false, null, base.Modifier));
        }
        #endregion
    }
}