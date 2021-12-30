namespace RtD.Data {
    public sealed class Main : Components.MessageBase {
        public Main() { }

        public Data LoadData(string aPathName, Enumerations.LanguageEnum aLanguage) {
            List<Components.Notification> lNotifications = new();
            Data lData = new();
            Json.EnemyClassesLoader lEnemyClasses = new(this);
            Json.ItemQualitiesLoader lItemQualitites = new(this);
            Json.ItemsLoader lItems = new(this);
            Json.LootLoader lLoots = new(this);

            base.RaiseMessage(lEnemyClasses.LoadData(aPathName));
            lData.EnemyClasses = lEnemyClasses.Data;

            base.RaiseMessage(lItemQualitites.LoadData(aPathName));
            lData.ItemQualities = lItemQualitites.Data;
            
            base.RaiseMessage(lItems.LoadData(aPathName));
            lData.Items = lItems.Data;
            
            base.RaiseMessage(lLoots.LoadData(aPathName));
            lData.Loot = lLoots.Data;

            return lData;
        }
    }
}