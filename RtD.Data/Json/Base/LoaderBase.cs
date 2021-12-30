namespace RtD.Data.Json {
    internal class LoaderBase<T> : Components.Filesystem.JsonBase<T> {
        #region Properties / Felder
        protected Main Parent;
        private List<Components.Notification> mNotifications = new List<Components.Notification>();
        #endregion

        #region Konstruktor
        protected LoaderBase(Main aParent) : base() { 
            Parent = aParent;
        }
        #endregion

        #region Methoden
        protected void LoadData(string aPathName, string aFileName) {
            base.LoadJson(new FileInfo(Path.Combine(aPathName, aFileName)));
        }

        protected IEnumerable<TT> RemoveEmpty<TT>(IEnumerable<TT> aData) where TT : JsonDataBase {
            if (aData.Where(x => string.IsNullOrWhiteSpace(x.Name)).Any()) {
                // TODO: Warning
                AddWarning(0);

                return aData.Where(x => !string.IsNullOrWhiteSpace(x.Name));
            } else {
                return aData;
            }
        }

        protected void Check4Dublicates<TT>(IEnumerable<TT> aData) where TT : JsonDataBase {
            if (!aData.Any()) {
                throw new Exceptions.MissingDataException();
            }

            if (aData
                .GroupBy(x => x.ID)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) {
                //TODO: Exception
            }

            if (aData
                .GroupBy(x => x.Name)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) {
                //TODO: Exception
            }
        }

        #region Notifications
        protected void AddWarning(long aID) {
            mNotifications.Add(new Components.Notification(Enumerations.PriorityEnum.Warning, aID));
        }

        protected void AddWarning(long aID, string aArguments) {
            mNotifications.Add(new Components.Notification(Enumerations.PriorityEnum.Warning, aID, aArguments));
        }

        protected Components.Notification[] GetNotifications(bool aClear = true) {
            Components.Notification[] lResult = new Components.Notification[mNotifications.Count];

            mNotifications.CopyTo(lResult);
            if (aClear) {
                mNotifications.Clear();
            }

            return lResult;
        }
        #endregion
        #endregion
    }
}