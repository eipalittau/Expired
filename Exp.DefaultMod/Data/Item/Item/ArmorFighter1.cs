﻿using Exp.Data.Item.Item;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.Item
{
    public sealed class ArmorFighter1 : ItemDataBase, IItemData {
        #region Konstruktor
        private ArmorFighter1()
            : base(nameof(ArmorFighter1), 1, 
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)), 
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Fighter)), false) {
            Name.Set(LanguageEnum.Deutsch, "Stoffrüstung des besiegten Kämpfers");
            Name.Set(LanguageEnum.English, "");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorFighter1());
        }
        #endregion
    }
}