﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Bow : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Bow()
            : base(nameof(Bow), 500, null, Api.Equipment.Slot.Singleton.Get("Mainhand"), Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bogen");
            Name.Set(Util.LanguageEnum.English, "Bow");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}