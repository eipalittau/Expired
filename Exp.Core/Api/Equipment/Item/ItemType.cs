namespace Exp.Api.Equipment {
    public sealed class ItemType : ApiBase<Data.Equipment.ItemTypeData> {
        #region Properties / Felder
        private static readonly ItemType mSingleton = new();
        #endregion

        #region Konstruktor
        internal ItemType() : base() {
            Add("Rüstung", 100, "Körper");
            Add("Stiefel", 200, "Füsse");
            Add("Einhandwaffe", 300, "Haupthand", "Nebenhand");
            Add("W10", 10, 400);
            Add("W12", 12, 500);
            Add("W20", 20, 600);
            Add("W100", 100, 700);
        }
        #endregion

        #region Methoden
        public static ItemType Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, params string[] aEquipmentSlots) {
            AddItem(aID, 0, null, aEquipmentSlots);
        }

        public void Add(string aID, Data.Equipment.ItemTypeData aParent, params string[] aEquipmentSlots) {
            AddItem(aID, 0, aParent, aEquipmentSlots);
        }

        public void Add(string aID, int aSortWeight, params string[] aEquipmentSlots) {
            AddItem(aID, aSortWeight, null, aEquipmentSlots);
        }

        public void Add(string aID, int aSortWeight, Data.Equipment.ItemTypeData aParent, params string[] aEquipmentSlots) {
            AddItem(aID, aSortWeight, aParent, aEquipmentSlots);
        }

        private void AddItem(string aID, int aSortWeight, Data.Equipment.ItemTypeData? aParent, params string[] aEquipmentSlots) {
            if (aEquipmentSlots == null || aEquipmentSlots.Length == 0) {
                //Patrik: Throw Missing Argument Execption
                throw new ArgumentNullException(nameof(aEquipmentSlots));
            }

            base.Add(new Data.Equipment.ItemTypeData(aID, aSortWeight, aParent, aEquipmentSlots.Select(x => Slot.Singleton.Get(x)).ToArray()));
        }
        #endregion
    }
}