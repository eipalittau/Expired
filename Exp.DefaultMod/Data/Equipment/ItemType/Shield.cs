﻿using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal sealed class Shield : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Shield()
            : base(nameof(Shield), 1000, null, Api.Equipment.Slot.Singleton.Get("Offhand")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schild");
            Name.Set(Util.LanguageEnum.English, "Shield");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}