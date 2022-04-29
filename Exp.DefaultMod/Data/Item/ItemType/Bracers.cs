﻿using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Bracers : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        internal Bracers()
            : base(nameof(Bracers), 1700, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.WristLeft)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.WristRight))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Armschutz");
            Name.Set(Util.LanguageEnum.English, "Bracers");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}