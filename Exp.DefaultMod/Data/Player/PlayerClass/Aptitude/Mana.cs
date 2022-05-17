using Exp.Data.Misc.Aptitude;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Mana : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public Mana()
            : base(nameof(Mana), Api.General.TargetEffectEnum.Mana) {
            base.Name.Set(Util.LanguageEnum.Deutsch, "Mana");
            base.Name.Set(Util.LanguageEnum.English, "Mana");
            base.LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Manapunkte um +1");
            base.LoreDescription.Set(Util.LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(0, 0, 1);

            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}