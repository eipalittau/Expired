namespace Exp.Data {
    public abstract class EnumBase {
        #region Enumerations
        public enum DirectionEnum : byte {
            None = 0,
            ASC = 1,
            DESC = 2
        }
        #endregion
        
        #region Properties / Felder
        public int ID { get; init; }
        public string Name { get; init; }
        #endregion
      
        #region Konstruktor
        protected EnumBase(int aID, string aName)
            => (ID, Name) = (aID, aName);   
        #endregion
      
        #region Methoden
        protected static List<T> Enumerate<T>(DirectionEnum aDirection) where T : EnumerationBase {
            List<T> lList = new();

            foreach (var lItem in typeof(T).GetFields().Where(x => x.IsStatic).Where(x => x.IsPublic)) {
                T? lValue = (T?)lItem.GetValue(null);
                if (lValue != null) {
                    lList.Add(lValue);
                }
            }

            return aDirection switch {
                DirectionEnum.ASC => lList.OrderBy(x => x.SortOrder).ToList(),
                DirectionEnum.DESC => lList.OrderByDescending(x => x.SortOrder).ToList(),
                _ => lList,
            };
        }

        protected static int Count<T>() {
            return typeof(T).GetFields().Length;
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
