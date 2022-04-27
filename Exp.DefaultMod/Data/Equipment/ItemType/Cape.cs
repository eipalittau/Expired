﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Cape : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Cape()
            : base(nameof(Cape), 1500, null, Api.Equipment.Slot.Singleton.Get("Shoulders")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Umhang");
            Name.Set(Util.LanguageEnum.English, "Cape");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}