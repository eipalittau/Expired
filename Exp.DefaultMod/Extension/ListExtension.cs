namespace Exp.Extension {
    internal static class ListExtension {
        public static bool Contains<T>(this List<T> aData, string aName) where T : Data.Feat.IFeatDataBase<T> {
            return aData.Select(x => x.Name.Get(aName)).Any();
        }
    }
}