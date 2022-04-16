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
        public int SortOrder { get; set; }
        #endregion
      
        #region Konstruktor
        protected EnumBase(int aID, string aName, int aSortOrder)
            => (ID, Name, SortOrder) = (aID, aName, aSortOrder);
        #endregion
      
        #region Methoden
        protected static IList<T> Enumerate<T>(DirectionEnum aDirection) where T : EnumerationBase {
            List<T> lList = new();

            foreach (var lItem in typeof(T).GetFields().Where(x => x.IsStatic).Where(x => x.IsPublic)) {
                T? lValue = (T?)lItem.GetValue(null);
                if (lValue != null) {
                    lList.Add(lValue);
                }
            }
            
            switch (aDirection) {
                case DirectionEnum.ASC:
                    lList.OrderBy(x => x.SortOrder).ToList();
                    break;
                    
                case DirectionEnum.DESC:
                    lList.OrderByDescending(x => x.SortOrder).ToList();
                    break;
                    
                default:
                    break;
            }
            
            return lList.AsReadOnly();
        }

        protected static int Count<T>() {
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
