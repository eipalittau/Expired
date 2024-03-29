﻿using Exp.Data.Misc.Aptitude;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass.Aptitude
{
    public sealed class LoseAction : AptitudeDataBase, IAptitudeData {
        #region Konstruktor
        public LoseAction()
            : base(nameof(LoseAction), Api.General.TargetEffectEnum.LoseAction, Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            base.Name.Set(LanguageEnum.Deutsch, "Schrei der Banshee");
            base.Name.Set(LanguageEnum.English, "Scream of the Banshee");
            base.LoreDescription.Set(LanguageEnum.Deutsch, "");
            base.LoreDescription.Set(LanguageEnum.English, "");
            base.Modifier = new Api.Helper.ModifierData(2, 1, 1);

            base.EffectList.Add(new Api.Helper.TargetEffect(base.ID, base.Effect, false, false, null, base.Modifier));
        }
        #endregion
    }
}