using Exp.Util.Extension;
using System.Reflection;

namespace Exp.Util {
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
                Message = string.Format(Localisation.GetText(ID, this.GetType().Assembly), aArguments);
            } else {
                Message = Localisation.GetText(base.Message, this.GetType().Assembly);
            }
        }
        #endregion
    }
}