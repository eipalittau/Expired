﻿using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Hardening : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal Hardening()
            : base(nameof(Hardening), 200,
                   Api.General.Tier.Singleton.Get(nameof(Exp.Data.General.Tier.One)),
                   null,
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Armor)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Boots)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Shield)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bracers)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Headgear))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Härten");
            Name.Set(Util.LanguageEnum.English, "Hardening");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}