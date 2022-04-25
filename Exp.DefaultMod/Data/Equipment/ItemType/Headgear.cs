﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Headgear : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Headgear()
            : base(nameof(Headgear), 1600, null, Api.Equipment.Slot.Singleton.Get("Head")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kopfbedeckung");
            Name.Set(Util.LanguageEnum.English, "Headgear");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}