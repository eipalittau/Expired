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
            Add("Zweihandwaffe", 400, "Haupthand", "Nebenhand");
            Add("Bogen", 500, "Haupthand", "Nebenhand");
            Add("Armbrust", 600, "Haupthand", "Nebenhand");
            Add("Pfeile", 700, base.Get("Bogen"), "Haupthand", "Nebenhand");
            Add("Bolzen", 800, base.Get("Armbrust"), "Haupthand", "Nebenhand");
            Add("Dolch", 900, "Nebenhand");
            Add("Schild", 1000, "Nebenhand");
            Add("Heiliges Symbol", 1100, "Nebenhand");
            Add("Zauberbuch", 1200, "Nebenhand");
            Add("Ring", 1300, "Ringfinger links", "Ringfinger rechts");
            Add("Amulett", 1400, "Hals");
            Add("Umhang", 1500, "Schultern");
            Add("Kopfbedeckung", 1600, "Kopf");
            Add("Armschutz", 1700, "Handgelenk links", "Handgelenk rechts");
            Add("Konsumierbar", 1800, "Tasche");
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