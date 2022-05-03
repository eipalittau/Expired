using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.Data.Player {
    public sealed class CharacterSheet : ICharacterSheetData {
        #region Properties / Felder
        public IPlayerClassData PlayerClass { get; init; }
        #endregion

        #region Konstruktor
        private CharacterSheet(IPlayerClassData aPlayerClass) : base() { 
            PlayerClass = aPlayerClass;
        }
        #endregion

        #region Methoden
        /*public CharacterSheet Create() {
            Exp.Api.General.DiceType.Singleton.Get(Exp.Api.Player.PlayerClass.Singleton.Count()).Roll;
            Exp.Api.Player.PlayerClass.Singleton.Get("");
            CharacterSheet lNew = new(aPlayerClass);

            return lNew;
        }*/

        public CharacterSheet Create(IPlayerClassData aPlayerClass) {
            CharacterSheet lNew = new(aPlayerClass);

            return lNew;
        }
        #endregion
    }
}