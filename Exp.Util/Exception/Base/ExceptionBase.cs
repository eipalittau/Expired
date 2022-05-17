using Exp.Util;
using Exp.Util.Extension;
using System.Text;

namespace Exp.Exception {
    public abstract class ExceptionBase : System.Exception {
        #region Properties / Felder
        public string ID { get; init; }
        public new string Message { get; init; }
        public DateTime Occurrence { get; init; }
        public PriorityEnum Priority { get; init; }
        #endregion

        #region Konstruktor
        protected ExceptionBase(params string[] aArguments)
            : this(null, aArguments) { }

        protected ExceptionBase(System.Exception? aEx, params string[] aArguments)
        : base() {
            Type lType = this.GetType();

            ID = string.Concat(lType.Namespace, ".", lType.Name);
            Occurrence = DateTime.Now;
            Priority = PriorityEnum.Error;

            if (aArguments.HasData()) {
                Message = ConcatWithInnerException(string.Format(Localisation.GetText(ID, lType.Assembly), aArguments), aEx);
            } else {
                Message = ConcatWithInnerException(Localisation.GetText(ID, lType.Assembly), aEx);
            }
        }

        private string ConcatWithInnerException(string aMessage, System.Exception? aEx) {
            if (aEx == null) {
                return aMessage;
            } else {
                string? lStacktrace = aEx.StackTrace;
                StringBuilder lMessage = new();

                if (!string.IsNullOrWhiteSpace(aMessage)) {
                    lMessage.AppendLine(aMessage);
                }

                do {
                    lMessage.AppendLine(aEx.Message);
                    aEx = aEx.InnerException;
                } while (aEx != null);

                if (!string.IsNullOrWhiteSpace(lStacktrace)) {
                    lMessage.AppendLine(lStacktrace);
                }

                return lMessage.ToString();
            }
        }
        #endregion
    }
}
