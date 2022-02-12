namespace RtD.Data {
    public sealed class Main : Components.MessageBase {
        #region Properties / Felder
        internal GameData Data { get; } = new();
        internal List<CharacterSheet> CharacterSheetList { get; } = new();

        private static readonly List<Components.EventArgs.MessageEventArgs> mNotifications = new();
        #endregion

        public Main() { }

        #region Methoden
        public GameData LoadData(string aPathName, Enumerations.LanguageEnum aLanguage) {
            try {
                Data.Clear();

                Data.EnemyClasses = new Json.EnemyClassesLoader(this, aLanguage).LoadData(aPathName);
                Data.ItemQualities = new Json.ItemQualitiesLoader(this, aLanguage).LoadData(aPathName);
                Data.Items = new Json.ItemsLoader(this, aLanguage).LoadData(aPathName);
                Data.Loots = new Json.LootsLoader(this, aLanguage).LoadData(aPathName);
                Data.PlayerClass = new Json.PlayerClassesLoader(this, aLanguage).LoadData(aPathName);
                Data.LevelUp = new Json.LevelUpLoader(this, aLanguage).LoadData(aPathName);

            } catch (Exceptions.ExceptionBase aEx) {
                mNotifications.Add(new Components.EventArgs.MessageEventArgs(aEx));

            } catch (System.Exception aEx) {
                mNotifications.Add(new Components.EventArgs.MessageEventArgs(aEx));

            } finally {
                if (mNotifications.Any()) {
                    base.RaiseMessage(mNotifications.ToArray());
                    mNotifications.Clear();
                }
            }
            
            return Data;
        }

        public CharacterSheet CreateNewCharacter(PlayerClassData aPlayerClass) {
            CharacterSheetList.Add(new CharacterSheet())
            CharacterSheet
        }

        #region Notifications
        internal static void AddWarning(long aID, params string[] aArguments) {
            if (aArguments == null) {
                mNotifications.Add(new Components.EventArgs.MessageEventArgs(aID, Enumerations.PriorityEnum.Warning));
            } else {
                if (aArguments.Where(x => x == null).Any()) {
                    aArguments.Where(x => x == null).ToList().ForEach(x => x = string.Empty);
                }

                mNotifications.Add(new Components.EventArgs.MessageEventArgs(aID, Enumerations.PriorityEnum.Warning, aArguments));
            }
        }
        #endregion
        #endregion
    }
}