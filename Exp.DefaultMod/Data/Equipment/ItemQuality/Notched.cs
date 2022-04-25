﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemQuality {
    internal sealed class Notched : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Notched()
            : base(nameof(Notched), 200, true, false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schartig");
            Name.Set(Util.LanguageEnum.English, "Notched");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}