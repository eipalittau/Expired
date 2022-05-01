using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.DefaultMod.Data.Player.CharacterSheet {
    public sealed class ArmorClassData {
        #region Properties / Felder
        public Exp.Data.General.IDamageTypeData DamageType { get; init; }
        #endregion

        #region Konstruktor
        internal ArmorClassData(Exp.Data.General.IDamageTypeData aDamageType) {
            DamageType = aDamageType;
        }
        #endregion
    }
}
