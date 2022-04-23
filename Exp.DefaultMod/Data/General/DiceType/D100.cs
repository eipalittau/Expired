﻿using Exp.Data.General;

namespace Exp.DefaultMod.General {
    internal sealed class D100 : DiceTypeBase, IDiceTypeData {
        #region Konstruktor
        internal D100()
            : base(nameof(D100), 700, 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "W100");
            Name.Set(Util.LanguageEnum.English, "D100");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}