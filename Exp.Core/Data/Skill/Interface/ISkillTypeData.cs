namespace Exp.Data.Skill {
    public interface ISkillTypeData : IDataBase {
        ISkillGroupData Group { get; set; }
    }
}