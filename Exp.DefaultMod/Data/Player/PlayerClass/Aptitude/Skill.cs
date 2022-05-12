﻿namespace Exp.DefaultMod.Player.PlayerClass.Aptitude {
    public sealed class Skill : Data.Misc.AptitudeDataBase, Data.Misc.IAptitudeData {
        #region Konstruktor
        public Skill()
            : base(nameof(Skill), Api.General.TargetEffectEnum.SkillPoints) {
            base.Name.Set(Util.LanguageEnum.Deutsch, "Fertigkeit");
            base.Name.Set(Util.LanguageEnum.English, "Skill");
            base.LoreDescription.Set(Util.LanguageEnum.Deutsch, "Ändert die Anzahl der Fertigkeitspunkte pro Level um +1");
            base.LoreDescription.Set(Util.LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(1, 0, 1);

            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}