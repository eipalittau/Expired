namespace Exp.Util {
    public abstract class EnumerationBase  {
        #region Enumerations
        public enum DirectionEnum : byte {
            None = 0,
            ASC = 1,
            DESC = 2
        }
        #endregion

        #region Properties / Felder
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Konstruktor
        protected EnumerationBase(int aID, string aName, string aDescription)
            => (ID, Name, Description) = (aID, aName, aDescription);
        #endregion

        #region Methoden
        protected static IList<T> Enumerate<T>(DirectionEnum aDirection) where T : EnumerationBase {
            IEnumerable<T> lList = typeof(T).GetFields()
                .Where(x => x.IsStatic && x.IsPublic)
                .Select(x => x.GetValue(null)).Cast<T>()
                .Where(x => x != null);

            return aDirection switch {
                DirectionEnum.ASC => lList.OrderBy(x => x.ID).ToList().AsReadOnly(),
                DirectionEnum.DESC => lList.OrderByDescending(x => x.ID).ToList().AsReadOnly(),
                _ => lList.ToList().AsReadOnly(),
            };
        }

        protected static int Count<T>() where T : EnumerationBase {
            return Enumerate<T>(DirectionEnum.None).Count;
        }

        protected static T Convert<T>(int aID, T aDefault) where T : EnumerationBase {
            return Enumerate<T>(DirectionEnum.None).Where(x => x.ID == aID).FirstOrDefault() ?? aDefault;
        }

        protected static T Convert<T>(string aName, T aDefault) where T : EnumerationBase {
            return Enumerate<T>(DirectionEnum.None).Where(x => x.Name == aName).FirstOrDefault() ?? aDefault;
        }

        public virtual new string ToString() {
            return Name;
        }
        #endregion
    }
}