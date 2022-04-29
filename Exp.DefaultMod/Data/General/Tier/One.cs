﻿namespace Exp.DefaultMod.General.Tier {
    public sealed class One : TierBase, Data.General.ITierData {
        #region Konstruktor
        internal One()
            : base(nameof(One), 1, 1) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stufe eins");
            Name.Set(Util.LanguageEnum.English, "Tier one");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}