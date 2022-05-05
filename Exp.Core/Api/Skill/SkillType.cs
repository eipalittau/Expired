namespace Exp.Api.Skill {
    public sealed class SkillType : ApiBase<Data.Skill.ISkillTypeData> {
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

        public new IList<Data.Skill.ISkillTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Skill.ISkillTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Skill.ISkillTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}