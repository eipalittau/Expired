using Exp.Data.Misc.Aptitude;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude
{
    public sealed class Health : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public Health()
            : base(nameof(Health), Api.General.TargetEffectEnum.Health) {
            base.Name.Set(LanguageEnum.Deutsch, "Lebenspunkt");
            base.Name.Set(LanguageEnum.English, "Health");
            base.LoreDescription.Set(LanguageEnum.Deutsch, "Ändert die Anzahl Lebenspunkte pro Level um +2");
            base.LoreDescription.Set(LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(1, 0, 2);
            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}