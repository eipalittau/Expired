using System.Reflection;

namespace Exp.Util.Extension {
    public static class AssemblyExtension {
        public static string TryGetName(this Assembly aData, string aPrefix = "", string aSuffix = "") {
            AssemblyName? lAssemblyName = aData.GetName();

            if (lAssemblyName == null) {
                return string.Empty;
            } else {
                return string.Concat(aPrefix, lAssemblyName.Name ?? lAssemblyName.FullName, aSuffix);
            }
        }

        public static bool IsEqual(this Assembly aData, Assembly aAssembly) {
            return TryGetName(aData).Equals(TryGetName(aAssembly), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}