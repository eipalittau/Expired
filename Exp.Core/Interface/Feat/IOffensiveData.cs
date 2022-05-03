namespace Exp.Data.Feat {
    public interface IOffensiveData : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        List<IOffensiveData> PrerequisiteList { get; }
        Util.LanguageBasedData EffektDescription { get; }

        void OnNewDay();
        void OnNewBattle();
        void OnNewRound();
        int OnAttackPassiv(params General.IDamageTypeData[] aDamageTypes);
        int OnDamagePassiv(params General.IDamageTypeData[] aDamageTypes);
        int OnAttackActive();
        int OnDamageActive();

        General.IDiceTypeData? OverrideDiceType(params General.IDamageTypeData[] aDamageTypes);
        //CharacterSheet GetExtraBoni(CharaterSheet aCharacterSheet);
    }
}
