namespace RtD.Data.Json { // Json/Loader
    internal sealed class LootsLoader : LoaderBase<Loot.LootJsonData> {
        #region Konstruktor
        internal LootsLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<LootData> LoadData(string aPathName) {
            List<LootData> lResult = new();
            IEnumerable<Loot.LootJsonData> lDouble;

            base.LoadData(aPathName, 3);

            if (base.JsonData.Where(x => x.DiceResult < 1).Any()) {
                Main.AddWarning(0002);
                base.JsonData
                    .Where(x => x.DiceResult < 1)
                    .ToList()
                    .ForEach(x => x.DiceResult = 1);
            }

            lDouble = base.JsonData.GroupBy(x => x.DiceResult).Where(g => g.Skip(1).Any()).SelectMany(x => x);
            if (lDouble.Any()) {
                throw new Exceptions.DublicateDataException(nameof(Loot.LootJsonData.DiceResult), lDouble.First().ID);
            }

            foreach (Loot.LootJsonData lJsonData in base.JsonData.OrderBy(x => x.DiceResult)) {
                IEnumerable<Loot.LootItemJsonData> lDoubleItem = lJsonData.Items.GroupBy(x => x.EnemyClass_ID).Where(g => g.Skip(1).Any()).SelectMany(x => x);

                if (lDoubleItem.Any()) {
                    throw new Exceptions.DublicateDataException(nameof(Loot.LootItemJsonData.EnemyClass_ID), lDoubleItem.First().Item_ID);
                }

                LootData lLootData = new() { DiceResult = lJsonData.DiceResult };

                foreach (Loot.LootItemJsonData lSubJsonData in lJsonData.Items) {
                    if (base.Parent.Data.EnemyClasses == null || base.Parent.Data.Items == null) {
                        Main.AddWarning(0004, lLootData.DiceResult.ToString(), base.FileNameData);
                    } else {
                        EnemyClassData? lEnemyClass = base.Parent.Data.EnemyClasses.FirstOrDefault(x => x.ID == lSubJsonData.EnemyClass_ID);
                        if (lEnemyClass == null) {
                            Main.AddWarning(0003, nameof(lSubJsonData.EnemyClass_ID), lSubJsonData.EnemyClass_ID.ToString(), base.FileNameData);
                            continue;

                        }

                        ItemData? lItem = base.Parent.Data.Items.FirstOrDefault(x => x.ID == lSubJsonData.Item_ID);
                        if (lItem == null) {
                            Main.AddWarning(0003, nameof(lSubJsonData.Item_ID), lSubJsonData.Item_ID.ToString(), base.FileNameData);
                            continue;
                        }

                        lLootData.LootItem.Add(new LootItemData(lEnemyClass, lItem));
                    }
                }

                if (lLootData.LootItem.Count > 0) {
                    lResult.Add(lLootData);
                }
            }

            return lResult;
        }
        #endregion
    }
}