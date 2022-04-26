﻿using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Chaos : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Chaos()
            : base(nameof(Chaos), 1900, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chaos");
            Name.Set(Util.LanguageEnum.English, "Chaos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}