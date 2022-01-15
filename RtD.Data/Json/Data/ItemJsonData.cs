﻿namespace RtD.Data.Json {
    internal sealed class ItemJsonData : JsonDataBase {
        public int ItemTypeEnum_ID { get; set; }
        public ArmorClassJsonData? ArmorClass { get; set; }
        public DamageJsonData? Damage { get; set; }
        public AttackJsonData? Attack { get; set; }
        public ManaJsonData? Mana { get; set; }
    }
}