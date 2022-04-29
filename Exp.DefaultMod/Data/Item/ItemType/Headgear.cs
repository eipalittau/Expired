﻿using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Headgear : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Headgear()
            : base(nameof(Headgear), 1600, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Head))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kopfbedeckung");
            Name.Set(Util.LanguageEnum.English, "Headgear");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}