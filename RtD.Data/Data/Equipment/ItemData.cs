namespace RtD.Data {
    //Tarik: Available On Start: Liste der Items, welche am Startpunkt erhältlich sind.
    public sealed class ItemData : DataBase {
        internal ItemData(Json.ItemJsonData aJsonData)
            : base(aJsonData.ID) {
            ItemType = ItemTypeEnum.Convert(aJsonData.ItemTypeEnum_ID);

            if (aJsonData.ArmorClass != null) {
                ArmorClass = new EffectData(aJsonData.ArmorClass);
            }
            if (aJsonData.Damage != null) {
                Damage = new EffectData(aJsonData.Damage);
            }
            if (aJsonData.Attack != null) {
                Attack = new EffectData(aJsonData.Attack);
            }
            if (aJsonData.Mana != null) {
                Damage = new EffectData(aJsonData.Mana);
            }
        }

        public ItemTypeEnum ItemType { get; set; }
        public EffectData? ArmorClass { get; set; }
        public EffectData? Damage { get; set; }
        public EffectData? Attack { get; set; }
        public EffectData? Mana { get; set; }
    }
}