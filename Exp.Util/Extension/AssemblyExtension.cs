using System.Reflection;

namespace Exp.Util.Extension {
    public static class AssemblyExtension {
        public static string TryGetName(this Assembly aData, string aPrefix = "", string aSuffix = "") {
            AssemblyName? lAssemblyName = aData.GetName();

            if (lAssemblyName == null || string.IsNullOrEmpty(lAssemblyName.Name)) {
                return string.Empty;
            } else {
                return string.Concat(aPrefix, lAssemblyName.Name, aSuffix);
            }
        }
    }
}