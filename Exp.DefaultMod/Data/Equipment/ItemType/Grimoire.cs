﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Grimoire : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Grimoire()
            : base(nameof(Grimoire), 1200, null, Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberbuch");
            Name.Set(Util.LanguageEnum.English, "Grimoire");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}