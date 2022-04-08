namespace RtD.Exceptions {
    public class MaxLevelReachedException : ExceptionBase {
        //Der Maximale level wurde überschritten.
        public MaxLevelReachedException(int aMaxLevel)
            : base(0002, aMaxLevel.ToString()) { }
    }
}