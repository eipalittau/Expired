namespace Exp.Exception {
    public sealed class MissingInitializationException : ExceptionBase {
        /// <summary>Die Main-Klasse wurde noch nicht initialisiert. Bitte führe die Methode Exp.Api.Main.Initizalize(int, bool) aus.</summary>
        public MissingInitializationException()
            : base() { }
    }
}