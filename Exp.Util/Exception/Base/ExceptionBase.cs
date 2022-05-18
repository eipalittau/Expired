using Exp.Util;
using Exp.Util.Extension;
using System.Diagnostics;
using System.Text;

namespace Exp.Exception {
    public abstract class ExceptionBase : System.Exception {
        #region Properties / Felder
        public string ID { get; init; }
        public new string Message { get; init; }
        public DateTime Occurrence { get; init; }
        public PriorityEnum Priority { get; init; }
        public IList<CallerData> CallerList {
            get {
                return _CallerList.AsReadOnly();
            }
        }

        private List<CallerData> _CallerList;
        #endregion

        #region Konstruktor
        protected ExceptionBase(params string[] aArguments)
            : this(null, aArguments) { }

        protected ExceptionBase(System.Exception? aEx, params string[] aArguments)
            : base() {
            StackTrace lStackTrace;
            Type lType = this.GetType();

            if (aEx == null) {
                lStackTrace = new(true);
            } else {
                if (string.IsNullOrWhiteSpace(aEx.StackTrace)) {
                    lStackTrace = new(true);
                } else {
                    lStackTrace = new(aEx, true);
                }
            }

            ID = string.Concat(lType.Namespace, ".", lType.Name);
            Occurrence = DateTime.Now;
            Priority = PriorityEnum.Error;
            _CallerList = lStackTrace.GetFrames()
                .Select(x => new CallerData(x))
                .Where(x => !x.ClassName.EqualsAny(lType.TryGetName(), lType.BaseType.TryGetName()))
                .ToList();

            if (aArguments.HasData()) {
                Message = ConcatWithInnerException(Localisation.GetText(ID, lType.Assembly, aArguments), aEx);
            } else {
                Message = ConcatWithInnerException(Localisation.GetText(ID, lType.Assembly), aEx);
            }
        }
        #endregion

        #region Methoden
        private string ConcatWithInnerException(string aMessage, System.Exception? aEx) {
            StringBuilder lMessage = new();

            if (!string.IsNullOrWhiteSpace(aMessage)) {
                lMessage.AppendLine(aMessage);
            }

            if (aEx != null) {
                do {
                    lMessage.AppendLine(aEx.Message);
                    aEx = aEx.InnerException;
                } while (aEx != null);
            }

            return lMessage.ToString();
        }
        #endregion
    }
}
