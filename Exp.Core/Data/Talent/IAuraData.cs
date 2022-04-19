namespace Exp.Data.Talent {
    public Interface IAuraData {
        string ID { get; set; }
        LanguageBasedData Name { get; set;}
        LanguageBasedData Description { get; set; }
        Int SortWeight { get; set; }
        Int Tier { get; set; }
        General.ActionTypeEnum? ActionType { get; set; }
        List<AuraData> Prerequisites { get; set; }
    }
}
