﻿namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class Hardening : Data.Profession.SmithingDataBase, Data.Profession.ISmithingData {
        #region Konstruktor
        private Hardening()
            : base(nameof(Hardening), 200,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Shield)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Bracers)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Headgear))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Härten");
            Name.Set(Util.LanguageEnum.English, "Hardening");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hardening());
        }
        #endregion
    }
}