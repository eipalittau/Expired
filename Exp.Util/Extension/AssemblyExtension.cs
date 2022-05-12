using System.Reflection;

namespace Exp.Util.Extension {
    public static class AssemblyExtension {
        public static string TryGetName(this Assembly aData) {
            AssemblyName? lAssemblyName = aData.GetName();

            if (lAssemblyName == null || lAssemblyName.Name == null) {
                return string.Empty;
            } else {
                return lAssemblyName.Name;
            }
        }
    }
}