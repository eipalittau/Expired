using Exp.Data.Skill.SkillGroup;
using Exp.Data.Skill.SkillType;

namespace Exp.Api.Skill {
    public sealed class SkillType : ApiBase<ISkillTypeData> {
        #region Properties / Felder
        public static SkillType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private SkillType() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<ISkillTypeData> Enumerate() {
            return base.Enumerate();
        }

        public IList<ISkillTypeData> Enumerate(ISkillGroupData aGroup) {
            return base.Enumerate()
                .Where(x => x.Group.Name.Get().Equals(aGroup.Name.Get(), StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        public new ISkillTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(ISkillTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}