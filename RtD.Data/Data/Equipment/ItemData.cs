namespace RtD.Data {
    //Patrik: Neues Property: AlwaysAvailable 
    public sealed class ItemData : DataBase {
        internal ItemData(Json.Item.ItemJsonData aJsonData)
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

        public ItemTypeEnum ItemType { get; private set; }
        public EffectData? ArmorClass { get; private set; }
        public EffectData? Damage { get; private set; }
        public EffectData? Attack { get; private set; }
        public EffectData? Mana { get; private set; }
    }
}