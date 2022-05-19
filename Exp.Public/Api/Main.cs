using Exp.Util;

namespace Exp.Api {
    public sealed class Main {
        #region Konstruktor
        public Main() {
            Localisation.AddResourceFile("Labeling.Labeling");

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