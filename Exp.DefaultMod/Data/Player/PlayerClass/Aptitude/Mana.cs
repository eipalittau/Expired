using Exp.Data.Misc.Aptitude;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude
{
    public sealed class Mana : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public Mana()
            : base(nameof(Mana), Api.General.TargetEffectEnum.Mana) {
            base.Name.Set(LanguageEnum.Deutsch, "Mana");
            base.Name.Set(LanguageEnum.English, "Mana");
            base.LoreDescription.Set(LanguageEnum.Deutsch, "Ändert die Manapunkte um +1");
            base.LoreDescription.Set(LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(0, 0, 1);

            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}