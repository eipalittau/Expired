namespace Exp.DefaultMod {
    public class Main : IMain {
        public void Initialize() {
            AddDiceTypeData();

            AddEnemyClassData();

            AddAuraData();
            AddDefensiveData();
            AddOffensiveData();
            AddWizardryData();
            AddWonderData();

            AddSlotData();
            AddItemTypeData();
            AddItemQualityData();
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
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Body());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Feet());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Mainhand());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Offhand());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.RingFingerLeft());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.RingFingerRight());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.WristLeft());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.WristRight());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Neck());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Shoulders());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Head());
            Api.Equipment.Slot.Singleton.Add(new Equipment.Slot.Bag());
        }

        private static void AddItemTypeData() {
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Armor());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Boots());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.OneHandedWeapon());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.TwoHandedWeapon());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Bow());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Crossbow());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Arrows());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Bolt());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Dagger());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Shield());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.HolySymbol());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Grimoire());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Ring());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Amulet());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Cape());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Headgear());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Armguard());
            Api.Equipment.ItemType.Singleton.Add(new Equipment.ItemType.Consumable());
        }

        private static void AddItemQualityData() {
            Data.Equipment.IItemQualityData lItem;

            Api.Equipment.ItemQuality.Singleton.Add(new Equipment.ItemQuality.Rusty());
            Api.Equipment.ItemQuality.Singleton.Add(new Equipment.ItemQuality.Notched());
            Api.Equipment.ItemQuality.Singleton.Add(new Equipment.ItemQuality.Normal());
            Api.Equipment.ItemQuality.Singleton.Add(new Equipment.ItemQuality.Hardened());
            Api.Equipment.ItemQuality.Singleton.Add(new Equipment.ItemQuality.Masterful());

            lItem = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Rusty));
            lItem.Downgrade = null;
            lItem.Upgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Notched));

            lItem = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Notched));
            lItem.Downgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Rusty));
            lItem.Upgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Normal));

            lItem = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Normal));
            lItem.Downgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Notched));
            lItem.Upgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Hardened));

            lItem = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Hardened));
            lItem.Downgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Normal));
            lItem.Upgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Masterful));

            lItem = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Masterful));
            lItem.Downgrade = Api.Equipment.ItemQuality.Singleton.Get(nameof(Equipment.ItemQuality.Hardened));
            lItem.Upgrade = null;
        }
        #endregion
    }
}