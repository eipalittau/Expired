namespace Exp.Data.Equipment {
    public sealed class ItemData : DataBase {
        #region Properties / Felder
        public bool AlwaysAvailable { get; private set; }
        public ItemTypeData ItemType { get; private set; }
        public EffectData? ArmorClass { get; private set; }
        public EffectData? Damage { get; private set; }
        public EffectData? Attack { get; private set; }
        public EffectData? Mana { get; private set; }
        #endregion

        #region Konstruktor
        internal ItemData(string aID, int aSortWeight, bool aAlwaysAvailable, string aItemType)
            : base(aID, aSortWeight)
            => Faces = aFaces;
        #endregion
    }
}