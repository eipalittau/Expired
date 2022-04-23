namespace Exp.DefaultMod {
    public class Main {
        public void StartUp() {
            AddDiceTypeData();

            AddEnemyClassData();

            AddAuraData();
            AddDefensiveData();
            AddOffensiveData();
            AddWizardryData();
            AddWonderData();

            AddSlotData();

            Api.Equipment.ItemQualityOld.Singleton.Get("Normal").DowngradeID = "";


            //Add("Rostig", null, "Schartig", 100, string.Empty, true, false);
            //Add("Schartig", "Rostig", "Normal", 200, string.Empty, true, false);
            //Add("Normal", "Schartig", "Gehärtet", 100, string.Empty, true, true);
            //Add("Gehärtet", "Normal", "Meisterhaft", 400, string.Empty, true, false);
            //Add("Meisterhaft", "Gehärtet", null, 500, string.Empty, false, false);
        }

        #region General
        private static void AddDiceTypeData() {
            Api.General.DiceType.Singleton.Add(new General.D4());
            Api.General.DiceType.Singleton.Add(new General.D6());
            Api.General.DiceType.Singleton.Add(new General.D8());
            Api.General.DiceType.Singleton.Add(new General.D10());
            Api.General.DiceType.Singleton.Add(new General.D12());
            Api.General.DiceType.Singleton.Add(new General.D20());
            Api.General.DiceType.Singleton.Add(new General.D100());
        }
        #endregion

        #region Enemy
        private static void AddEnemyClassData() {
            Api.Enemy.EnemyClass.Singleton.Add(new Enemy.Mage());
            Api.Enemy.EnemyClass.Singleton.Add(new Enemy.Cleric());
            Api.Enemy.EnemyClass.Singleton.Add(new Enemy.Rogue());
            Api.Enemy.EnemyClass.Singleton.Add(new Enemy.Fighter());
        }
        #endregion

        #region Feat
        private static void AddAuraData() {
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Fencer());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Power());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Defense());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Reflexes());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Will());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Anger());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Focus());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Enhanced());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Flatulence());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.BrokenWingsGambit());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Agile());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Coordinated());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.LoveAndPieces());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Sadist());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Masochist());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Perfection());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.Interdisciplinary());
            Api.Feat.Aura.Singleton.Add(new Feat.Aura.BannerBearer());
        }

        private static void AddDefensiveData() {
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Jostle());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Tough());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.FelineReflex());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.DangerInstinct());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Dodge());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Agile());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Teamplayer());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Pindown());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Shadowy());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.SecondWind());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Teamwork());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.StoneSkin());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.ImprovedDodge());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.PussInBoots());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.RoadRunner());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Hermes());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Hephaistos());
            Api.Feat.Defensive.Singleton.Add(new Feat.Defensive.Zeus());
        }

        private static void AddOffensiveData() {
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.BattleHardened());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Stonethrower());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.EloquentInsulte());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.PreciseShot());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.SweepingBlow());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Charge());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Teamplayer());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.TwoWeapons());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.StrongCharge());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Teamwork());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.QuickMouth());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Sneaky());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.QuickShot());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Anatomy());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.BetterTwoWeapons());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Riposte());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.ThornSkin());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Cthulhu());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Chaos());
            Api.Feat.Offensive.Singleton.Add(new Feat.Offensive.Hades());
        }

        private static void AddWizardryData() {
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.MagicWave());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.StinkyCloud());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Reflection());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Shield());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Fright());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.FitOfLaughter());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.SpellFocus());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.MagicPower());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Icicle());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Fireball());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.HoldPerson());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Metamagic());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.ImprovedMagicWave());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.SpellFocus2());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.MagicPower2());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Chronos());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Dionysos());
            Api.Feat.Wizardry.Singleton.Add(new Feat.Wizardry.Thanos());
        }

        private static void AddWonderData() {
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.IceArmor());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.MagicWeapon());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.MiracleDoll());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.ThingT());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Haste());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Lubricate());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.MiracleFocus());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.MiraculousPower());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.DiamondArmor());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.AccurateWeapon());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.ChannelingNegativeEnergy());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Mob());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Brains());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.MiracleFocus2());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.MiraculousPower2());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Tartaros());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Nyx());
            Api.Feat.Wonder.Singleton.Add(new Feat.Wonder.Styx());
        }
        #endregion

        #region Equipment
        private static void AddSlotData() {
            Api.Equipment.Slot.Singleton.Add(new Equipment.Armor());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Feet());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Mainhand());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Offhand());
            Api.Equipment.Slot.Singleton.Add(new Equipment.RingFingerLeft());
            Api.Equipment.Slot.Singleton.Add(new Equipment.RingFingerRight());
            Api.Equipment.Slot.Singleton.Add(new Equipment.WristLeft());
            Api.Equipment.Slot.Singleton.Add(new Equipment.WristRight());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Neck());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Shoulders());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Head());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Bag());
        }
        #endregion
    }
}