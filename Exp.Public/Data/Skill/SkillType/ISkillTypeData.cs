using Exp.Data.Skill.SkillGroup;

namespace Exp.Data.Skill.SkillType {
    public interface ISkillTypeData : IDataBase {
        ISkillGroupData Group { get; set; }
    }
}