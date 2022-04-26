namespace Exp.Data {
    public interface IDataBase {
        string ID { get; init; }
        Util.LanguageBasedData Name { get; }
        Util.LanguageBasedData LoreDescription { get; }
        int SortWeight { get; set; }
    }
}