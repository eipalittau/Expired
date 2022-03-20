namespace RtD.Data.Json { // Json/Data/Base
    internal abstract class JsonDataBase {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}