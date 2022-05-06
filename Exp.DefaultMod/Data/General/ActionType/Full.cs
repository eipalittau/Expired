﻿namespace Exp.DefaultMod.General.ActionType {
    public sealed class Full : ActionTypeBase, Data.General.IActionTypeData {
        #region Konstruktor
        internal Full()
            : base(nameof(Full), 4, 2.5) {
            Name.Set(Util.LanguageEnum.Deutsch, "Volle Aktion");
            Name.Set(Util.LanguageEnum.English, "Full action");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Verbracht eine Standard- und eine Bewegungsaktion.");
            LoreDescription.Set(Util.LanguageEnum.English, "Uses up a Standard- and Movement Action.");
        }
        #endregion
    }
}