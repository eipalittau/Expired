using Exp.Api.Player;
using Exp.Util;

namespace Exp.Core {
    public sealed class Main {
        #region Properties / Felder
        public int Experience { get; private set; }
        #endregion

        #region Konstruktor
        public Main(LanguageEnum aLanguage, bool aThrowException) {
            try {
                ExceptionHandler.ThrowException = aThrowException;
                Localisation.AddResourceFile("Labeling.Labeling");
                SetLanguage(aLanguage);
                AddNone();

            } catch (System.Exception aEx) {

            }
        }
        #endregion

        #region Methoden
        public CharacterSheet CreateCharacter() {
            return CharacterSheet.Create(Experience);
        }

        public CharacterSheet CreateCharacter(Data.Player.PlayerClass.IPlayerClassData aPlayerClass) {
            return CharacterSheet.Create(aPlayerClass, Experience);
        }

        public void SetLanguage(LanguageEnum aLanguage) {
            Localisation.Language = aLanguage;
        }

        public void SetExperience4LevelUp(int aValue) {
            Experience = aValue;
        }

        private void AddNone() {
            //General
            Data.General.ActionType.None.Add();
            Data.General.DamageType.None.Add();
            Data.General.DiceType.None.Add();
            Data.General.Tier.None.Add();

            //Enemy
            Data.Enemy.EnemyClass.None.Add();

            //Item
            Data.Item.Effect.None.Add();
            Data.Item.ItemType.None.Add();
            Data.Item.Item.None.Add();
            Data.Item.ItemQuality.None.Add();

            //Feat
            Data.Feat.Aura.None.Add();
            Data.Feat.Defensive.None.Add();
            Data.Feat.Offensive.None.Add();
            Data.Feat.Wizardry.None.Add();
            Data.Feat.Wonder.None.Add();

            //Misc
            Data.Misc.Recollection.None.Add();

            //Skill
            Data.Skill.SkillGroup.None.Add();
            Data.Skill.SkillType.None.Add();

            //Profession
            Data.Profession.Smithing.None.Add();

            //Player
            Data.Player.PlayerClass.None.Add();
            Data.Player.LevelUp.None.Add();
            Data.Player.Slot.None.Add();
        }
        #endregion
    }
}