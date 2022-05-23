using Exp.Data.Misc.Aptitude;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Health : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public Health()
            : base(nameof(Health), Api.General.TargetEffectEnum.Health) {
            base.Name.Set(Util.LanguageEnum.Deutsch, "Lebenspunkt");
            base.Name.Set(Util.LanguageEnum.English, "Health");
            base.LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Anzahl Lebenspunkte pro Level um +2");
            base.LoreDescription.Set(Util.LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(1, 0, 2);
            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}