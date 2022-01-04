namespace RtD.Data.Json {
    internal sealed class LootsLoader : LoaderBase<LootsLoader.JsonData> {
        #region Properties / Felder
        public List<LootData> Data { get; } = new List<LootData>();
        #endregion

        #region Konstruktor
        internal LootsLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public Components.EventArgs.MessageEventArgs[] LoadData(string aPathName) {
            base.LoadData(aPathName, Constants.GetJsonFileName(3));

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                if (base.Json.Data.Where(x => x.DiceResult < 1).Any()) {
                    base.AddWarning(010002);
                    base.Json.Data
                        .Where(x => x.DiceResult < 1)
                        .ToList()
                        .ForEach(x => x.DiceResult = 1);
                }

                if (base.Json.Data
                    .GroupBy(x => x.DiceResult)
                    .Where(g => g.Skip(1).Any())
                    .SelectMany(x => x)
                    .Any()) {
                    throw new Exceptions.DublicateDataException(nameof(LootJsonData.DiceResult));
                }

                foreach (LootJsonData lJsonData in base.Json.Data
                    .OrderBy(x => x.DiceResult)) {
                    if (lJsonData.Items
                        .GroupBy(x => x.EnemyClass_ID)
                        .Where(g => g.Skip(1).Any())
                        .SelectMany(x => x)
                        .Any()) {
                        throw new Exceptions.DublicateDataException(nameof(LootItemJsonData.EnemyClass_ID));
                    }

                    base.Parent.
                    foreach (LootItemJsonData lSubJsonData in lJsonData.Items) {

                        lSubJsonData.Item_ID
                        LootItemData lLootItem = new LootItemData();

                    }

                    LootData lLoot = new LootData(lJsonData);
                    lLoot.LootItem
                    Data.Add(new LootData(lJsonData));
                }


                    foreach (ItemJsonData lJsonData in lData
                    .OrderBy(x => x.ItemTypeEnum_ID)
                    .ThenBy(x => x.Name)) {
                    Data.Add(new ItemData(lJsonData));
                }
            }

            return base.GetNotifications();
        }
        #endregion

        #region Verschachtete Klassen
        public class JsonData {
            public List<LootJsonData> Data { get; } = new();
        }
        #endregion
    }
}