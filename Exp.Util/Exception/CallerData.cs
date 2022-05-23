using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace Exp.Exception {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class CallerData {
        #region Properties / Felder
        public string AssemblyName { get; init; } = string.Empty;
        public string ClassName { get; init; } = string.Empty;
        public string MethodName { get; init; } = string.Empty;
        public int LineNumber { get; init; } = int.MinValue;
        #endregion

        #region Konstruktor
        internal CallerData(StackFrame aFrame) {
            MethodBase? lMethodBase = aFrame.GetMethod();

            LineNumber = aFrame.GetFileLineNumber();

            if (lMethodBase != null) {
                Type? lDeclaringType = lMethodBase.DeclaringType;

                MethodName = lMethodBase.Name;
                AssemblyName = lMethodBase.Module.Assembly.GetName().Name ?? string.Empty;

                if (lDeclaringType != null) {
                    ClassName = lDeclaringType.FullName ?? lDeclaringType.Name;
                }
            }
        }
        #endregion
    }
}
