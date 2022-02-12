namespace RtD.Data.Json {
    internal sealed class LootsLoader : LoaderBase<LootJsonData> {
        #region Konstruktor
        internal LootsLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<LootData> LoadData(string aPathName) {
            List<LootData> lResult = new();

            base.LoadData(aPathName, 3);

            if (base.JsonData.Where(x => x.DiceResult < 1).Any()) {
                Main.AddWarning(0002);
                base.JsonData
                    .Where(x => x.DiceResult < 1)
                    .ToList()
                    .ForEach(x => x.DiceResult = 1);
            }

            if (base.JsonData.GroupBy(x => x.DiceResult).Where(g => g.Skip(1).Any()).SelectMany(x => x).Any()) {
                throw new Exceptions.DublicateDataException(nameof(LootJsonData.DiceResult));
            }

            foreach (LootJsonData lJsonData in base.JsonData.OrderBy(x => x.DiceResult)) {
                if (lJsonData.Items
                    .GroupBy(x => x.EnemyClass_ID)
                    .Where(g => g.Skip(1).Any())
                    .SelectMany(x => x)
                    .Any()) {
                    throw new Exceptions.DublicateDataException(nameof(LootItemJsonData.EnemyClass_ID));
                }

                LootData lLootData = new() { DiceResult = lJsonData.DiceResult };

                foreach (LootItemJsonData lSubJsonData in lJsonData.Items) {
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