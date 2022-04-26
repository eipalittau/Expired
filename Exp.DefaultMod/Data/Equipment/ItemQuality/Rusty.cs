﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemQuality {
    internal sealed class Rusty : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Rusty()
            : base(nameof(Rusty), 100, true, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rostig");
            Name.Set(Util.LanguageEnum.English, "Rusty");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}