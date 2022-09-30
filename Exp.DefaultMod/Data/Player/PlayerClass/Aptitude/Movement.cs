using Exp.Data.Misc.Aptitude;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude
{
    public sealed class Movement : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public Movement()
            : base(nameof(Movement), Api.General.TargetEffectEnum.Movement) {
            base.Name.Set(LanguageEnum.Deutsch, "Bewegungsrate");
            base.Name.Set(LanguageEnum.English, "Movement");
            base.LoreDescription.Set(LanguageEnum.Deutsch, "Ändert die Bewegungsrate um +1 Feld pro 2 Level");
            base.LoreDescription.Set(LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(2, 0, 1);

            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}