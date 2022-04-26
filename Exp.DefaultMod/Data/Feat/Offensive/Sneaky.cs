﻿using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Sneaky : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Sneaky()
            : base(nameof(Sneaky), 1200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hinterhältig");
            Name.Set(Util.LanguageEnum.English, "Sneaky");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}