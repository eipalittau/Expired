using Exp.Data.Skill.SkillGroup;

namespace Exp.Api.Skill {
    public sealed class SkillGroup : ApiBase<ISkillGroupData> {
        #region Properties / Felder
        public static SkillGroup Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private SkillGroup() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<ISkillGroupData> Enumerate() {
            return base.Enumerate();
        }

        public new ISkillGroupData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(ISkillGroupData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}