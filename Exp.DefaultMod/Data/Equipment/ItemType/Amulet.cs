﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Amulet : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Amulet()
            : base(nameof(Amulet), 1400, null, Api.Equipment.Slot.Singleton.Get("Neck")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Amulett");
            Name.Set(Util.LanguageEnum.English, "Amulet");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}