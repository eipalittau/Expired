namespace Exp.Util {
    public abstract class EnumerationBase : EnumerationMethodBase {
        #region Properties / Felder
        public int ID { get; init; }
        public LanguageBasedData Name { get; } = new LanguageBasedData();
        public LanguageBasedData Description { get; } = new LanguageBasedData();
        #endregion

        #region Konstruktor
        protected EnumerationBase(int aID)
            => ID = aID;
        #endregion

        #region Methoden
        protected static List<T> Enumerate<T>(Enumeration.SortDirectionEnum aSortDirection) where T : EnumerationBase {
            return aSortDirection switch {
                Enumeration.SortDirectionEnum.ASC => EnumerationMethodBase.Enumerate<T>().OrderBy(x => x.ID).ToList(),
                Enumeration.SortDirectionEnum.DESC => EnumerationMethodBase.Enumerate<T>().OrderByDescending(x => x.ID).ToList(),
                _ => EnumerationMethodBase.Enumerate<T>()
            };
        }

        protected static T Convert<T>(int aID, T aDefault) where T : EnumerationBase {
            return EnumerationMethodBase.Enumerate<T>().Where(x => x.ID == aID).FirstOrDefault() ?? aDefault;
        }

        protected static T Convert<T>(string aName, LanguageEnum aLanguage, T aDefault) where T : EnumerationBase {
            return EnumerationMethodBase.Enumerate<T>().Where(x => x.Name.Value(aLanguage).Equals(aName, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault() ?? aDefault;
        }

        public virtual new string ToString() {
            return ToString(LanguageEnum.Fallback);
        }

        public virtual string ToString(LanguageEnum aLanguage) {
            return Name.Value(aLanguage);
        }
        #endregion
    }
}