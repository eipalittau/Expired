namespace Exp.Util {
    public abstract class EnumerationBase {
        #region Enumeration
        public enum SortDirectionEnum : byte {
            None = 0,
            ASC = 1,
            DESC = 2
        }
        #endregion

        #region Properties / Felder
        public int ID { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        #endregion

        #region Konstruktor
        protected EnumerationBase(int aID, string aName, string aDescription)
            => (ID, Name, Description) = (aID, aName, aDescription);
        #endregion

        #region Methoden
        protected static List<T> Enumerate<T>() where T : EnumerationBase {
            return Enumerate<T>(SortDirectionEnum.ASC);
        }

        protected static List<T> Enumerate<T>(SortDirectionEnum aSortDirection) where T : EnumerationBase {
            List<T>? lList = typeof(T).GetFields()
                .Where(x => x.IsStatic && x.IsPublic)
                .Select(x => (T?)x.GetValue(null)).OfType<T>().ToList();

            return aSortDirection switch {
                SortDirectionEnum.ASC => lList.OrderBy(x => x.ID).ToList(),
                SortDirectionEnum.DESC => lList.OrderByDescending(x => x.ID).ToList(),
                _ => lList,
            };
        }

        protected static int Count<T>() where T : EnumerationBase {
            return Enumerate<T>().Count;
        }

        protected static T Convert<T>(int aID, T aDefault) where T : EnumerationBase {
            return Enumerate<T>().Find(x => x.ID == aID) ?? aDefault;
        }

        protected static T Convert<T>(string aName, T aDefault) where T : EnumerationBase {
            return Enumerate<T>().Find(x => x.Name.Equals(aName, StringComparison.InvariantCultureIgnoreCase)) ?? aDefault;
        }

        public virtual new string ToString() {
            return Name;
        }
        #endregion
    }
}
