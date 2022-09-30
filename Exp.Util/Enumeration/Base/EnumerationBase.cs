namespace Exp.Util.Enumeration.Base {
    public abstract class EnumerationBase {
        #region Properties / Felder
        public long Index { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        #endregion

        #region Konstruktor
        protected EnumerationBase(int aIndex, string aName, string aDescription)
            => (Index, Name, Description) = (aIndex, aName, aDescription);
        #endregion

        #region Methoden
        #region Enumerate
        protected static List<T> Enumerate<T>() where T : EnumerationBase {
            return typeof(T).GetFields()
                .Where(x => x.IsStatic && x.IsPublic)
                .Select(x => (T?)x.GetValue(null)).OfType<T>().ToList();
        }

        protected static List<T> EnumerateByIndex<T>(SortDirectionEnum aSortDirection) where T : EnumerationBase {
            return aSortDirection.SortByIndex(Enumerate<T>());
        }

        protected static List<T> EnumerateByName<T>(SortDirectionEnum aSortDirection) where T : EnumerationBase {
            return aSortDirection.SortByName(Enumerate<T>());
        }
        #endregion

        #region Convert
        protected static T Convert<T>(long aIndex, T aDefault) where T : EnumerationBase {
            return Enumerate<T>().Find(x => x.Index == aIndex) ?? aDefault;
        }

        protected static T Convert<T>(string aName, T aDefault) where T : EnumerationBase {
            return Enumerate<T>().Find(x => x.Name.Equals(aName, StringComparison.InvariantCultureIgnoreCase)) ?? aDefault;
        }
        #endregion

        #region Equals
        public bool NameEquals<T>(T aValue) where T : EnumerationBase {
            return Name.Equals(aValue.Name, StringComparison.InvariantCultureIgnoreCase);
        }

        public bool IndexEquals<T>(T aValue) where T : EnumerationBase {
            return Index == aValue.Index;
        }

        protected bool NameEqualsAny<T>(params T[] aValues) where T : EnumerationBase {
            if (aValues?.Length > 0) {
                return aValues.Any(x => Name.Equals(x.Name, StringComparison.InvariantCultureIgnoreCase));
            }

            return false;
        }
        #endregion

        protected static int Count<T>() where T : EnumerationBase {
            return Enumerate<T>().Count;
        }

        public virtual new string ToString() {
            return Name;
        }
        #endregion
    }
}
