namespace RtD.Data {
    public class ResourceData {
        public int Current { get; set; }
        public int Max { get; set; }
        /// <summary>Liste. Wie setzt sich der Wert "Current" zusammen.</summary>
        public List<HistoryData> History { get; } = new List<HistoryData>();
    }
}