﻿using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Sharpen : SmithingDataBase, ISmithingData {
        #region Konstruktor
        internal Sharpen()
            : base(nameof(Sharpen), 100, 
                   Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), 
                   null,
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.OneHandedWeapon)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.TwoHandedWeapon)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bow)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Crossbow)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Arrows)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Bolt)),
                   Api.Equipment.ItemType.Singleton.Get(nameof(Equipment.ItemType.Dagger))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schärfen");
            Name.Set(Util.LanguageEnum.English, "Sharpen");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}