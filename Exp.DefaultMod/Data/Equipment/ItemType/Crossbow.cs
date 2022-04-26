﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Crossbow : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Crossbow()
            : base(nameof(Crossbow), 600, null, Api.Equipment.Slot.Singleton.Get("Mainhand"), Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Armbrust");
            Name.Set(Util.LanguageEnum.English, "Crossbow");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}