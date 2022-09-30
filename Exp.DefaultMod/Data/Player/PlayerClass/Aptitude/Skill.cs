using Exp.Data.Misc.Aptitude;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude
{
    public sealed class Skill : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public Skill()
            : base(nameof(Skill), Api.General.TargetEffectEnum.SkillPoints) {
            base.Name.Set(LanguageEnum.Deutsch, "Fertigkeit");
            base.Name.Set(LanguageEnum.English, "Skill");
            base.LoreDescription.Set(LanguageEnum.Deutsch, "Ändert die Anzahl der Fertigkeitspunkte pro Level um +1");
            base.LoreDescription.Set(LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(1, 0, 1);

            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, true, false, base.Modifier, null));
        }
        #endregion
    }
}