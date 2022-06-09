namespace Exp.Exception {
    public sealed class EmptyListException : ExceptionBase {
        /// <summary>In der Liste '{0}' sind keine Elemente vorhanden.</summary>
        public EmptyListException(Type aClass)
            : base(aClass.Name) { }
    }
}