﻿using Exp.Data.Skill.SkillGroup;

namespace Exp.Data.Skill.SkillType {
    public abstract class SkillTypeDataBase : DataBase {
        #region Properties / Felder
        public ISkillGroupData Group { get; set; }
        #endregion

        #region Konstruktor
        protected SkillTypeDataBase(string aID, int aSortWeight, ISkillGroupData aGroup)
            : base(aID, aSortWeight)
            => Group = aGroup;
        #endregion

        #region Methoden
        protected static void AddInstance(ISkillTypeData aInstance) {
            Api.Skill.SkillType.Singleton.Add(aInstance);
        }
        #endregion
    }
}