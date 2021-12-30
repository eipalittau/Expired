using System.Diagnostics;

namespace RtD.Components.EventArgs {
    public sealed class InternalMessageEventArgs {
        public InternalMessageEventArgs(long aID, Enumerations.PriorityEnum aPriority) {
            ID = aID;
            Priority = aPriority;
            Position = new PositionData(new StackTrace(true).GetFrame(3));
            Arguments = new();
        }

        public InternalMessageEventArgs(long aID, Enumerations.PriorityEnum aPriority, params string[] aArguments) {
            ID = aID;
            Priority = aPriority;
            Position = new PositionData(new StackTrace(true).GetFrame(3));
            Arguments = aArguments.ToList();
        }

        public long ID { get; set; }
        public List<string> Arguments { get; set; }
        public Enumerations.PriorityEnum Priority { get; set; } = Enumerations.PriorityEnum.None;
        public PositionData Position { get; set; }
    }
}
