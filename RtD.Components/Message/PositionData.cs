using System.Diagnostics;
using System.Reflection;

namespace RtD.Components
{
    public sealed class PositionData
    {
        #region Konstruktor
        public PositionData(StackFrame? aStackFrame)
        {
            if (aStackFrame != null)
            {
                MethodBase? lMethod = aStackFrame.GetMethod();

                if (lMethod != null)
                {
                    Type? lType = lMethod.DeclaringType;

                    if (lType != null)
                    {
                        Classname = lType.FullName ?? lType.Name;
                    }

                    Methodname = lMethod.Name;
                }

                Linenumber = aStackFrame.GetFileLineNumber();
            }
        }
        #endregion

        #region Properties / Felder
        public string Classname { get; private set; } = string.Empty;
        public string Methodname { get; private set; } = string.Empty;
        public int Linenumber { get; private set; }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return $"Class: {Classname} / Method: {Methodname} / Line: {Linenumber}";
        }
        #endregion
    }
}