namespace Exp.Data {
    public interface IDataBase {
        string ID { get; set; }
        Util.LanguageBasedData Name { get; }
        Util.LanguageBasedData Description { get; }
        int SortWeight { get; set; }
    }
}