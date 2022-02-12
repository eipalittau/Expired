namespace RtD.Exceptions
{
    public class MissingDataException : ExceptionBase
    {
        public MissingDataException()
            : base(0000) { }

        //Patrik: Exception beachten
        public MissingDataException(System.Exception aEx)
            : base(0000) { }
    }
}