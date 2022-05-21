namespace Exp.DefaultMod {
    public class Main : IMain {
        public List<string> Dependency { get; } = new ();

        public Main() { }

        public void Initialize() {
            // General
            AddActionTypeData();
            AddDamageTypeData();
            AddDiceTypeData();
            AddTierData();

            // Enemy
            AddEnemyClassData();

            // Feat
            AddAuraData();
            AddDefensiveData();
            AddOffensiveData();
            AddWizardryData();
            AddWonderData();

            //Profession
            AddSmithingData();

            // Skill
            AddSkillGroupData();
            AddSkillTypeData();

            // Item
            AddEffectData();
            AddItemData();
            AddItemQualityData();
            AddItemTypeData();

            //Misc
            AddRecollectionData();

            // Player
            AddLevelUp();
            AddPlayerClassData();
            AddSlotData();
        }

        #region General
        private static void AddActionTypeData() {
            General.ActionType.Free.Add();
            General.ActionType.Move.Add();
            General.ActionType.Standard.Add();
            General.ActionType.Full.Add();
        }

        private static void AddDamageTypeData() {
            General.DamageType.Melee.Add();
            General.DamageType.RangedCombat.Add();
            General.DamageType.Magic.Add();
        }

        private static void AddDiceTypeData() {
            General.DiceType.D4.Add();
            General.DiceType.D6.Add();
            General.DiceType.D8.Add();
            General.DiceType.D10.Add();
            General.DiceType.D12.Add();
            General.DiceType.D20.Add();
            General.DiceType.D100.Add();
        }

        private static void AddTierData() {
            General.Tier.One.Add();
            General.Tier.Two.Add();
            General.Tier.Three.Add();
        }
        #endregion

        #region Enemy
        private static void AddEnemyClassData() {
            Enemy.EnemyClass.Mage.Add();
            Enemy.EnemyClass.Cleric.Add();
            Enemy.EnemyClass.Rogue.Add();
            Enemy.EnemyClass.Fighter.Add();
        }
        #endregion

        #region Feat
        private static void AddAuraData() {
            Feat.Aura.Fencer.Add();
            Feat.Aura.Power.Add();
            Feat.Aura.Defense.Add();
            Feat.Aura.Reflexes.Add();
            Feat.Aura.Will.Add();
            Feat.Aura.Anger.Add();
            Feat.Aura.Focus.Add();
            Feat.Aura.Enhanced.Add();
            Feat.Aura.Flatulence.Add();
            Feat.Aura.BrokenWingsGambit.Add();
            Feat.Aura.Agile.Add();
            Feat.Aura.Coordinated.Add();
            Feat.Aura.LoveAndPieces.Add();
            Feat.Aura.Sadist.Add();
            Feat.Aura.Masochist.Add();
            Feat.Aura.Perfection.Add();
            Feat.Aura.Interdisciplinary.Add();
            Feat.Aura.BannerBearer.Add();
        }

        private static void AddDefensiveData() {
            Feat.Defensive.Jostle.Add();
            Feat.Defensive.Tough.Add();
            Feat.Defensive.FelineReflex.Add();
            Feat.Defensive.DangerInstinct.Add();
            Feat.Defensive.Dodge.Add();
            Feat.Defensive.Agile.Add();
            Feat.Defensive.Teamplayer.Add();
            Feat.Defensive.Pindown.Add();
            Feat.Defensive.Shadowy.Add();
            Feat.Defensive.SecondWind.Add();
            Feat.Defensive.Teamwork.Add();
            Feat.Defensive.StoneSkin.Add();
            Feat.Defensive.ImprovedDodge.Add();
            Feat.Defensive.PussInBoots.Add();
            Feat.Defensive.RoadRunner.Add();
            Feat.Defensive.Hermes.Add();
            Feat.Defensive.Hephaistos.Add();
            Feat.Defensive.Zeus.Add();
        }

        private static void AddOffensiveData() {
            Feat.Offensive.BattleHardened.Add();
            Feat.Offensive.Stonethrower.Add();
            Feat.Offensive.EloquentInsulte.Add();
            Feat.Offensive.PreciseShot.Add();
            Feat.Offensive.SweepingBlow.Add();
            Feat.Offensive.Charge.Add();
            Feat.Offensive.Teamplayer.Add();
            Feat.Offensive.TwoWeapons.Add();
            Feat.Offensive.StrongCharge.Add();
            Feat.Offensive.Teamwork.Add();
            Feat.Offensive.QuickMouth.Add();
            Feat.Offensive.Sneaky.Add();
            Feat.Offensive.QuickShot.Add();
            Feat.Offensive.Anatomy.Add();
            Feat.Offensive.BetterTwoWeapons.Add();
            Feat.Offensive.Riposte.Add();
            Feat.Offensive.ThornSkin.Add();
            Feat.Offensive.Cthulhu.Add();
            Feat.Offensive.Chaos.Add();
            Feat.Offensive.Hades.Add();
        }

        private static void AddWizardryData() {
            Feat.Wizardry.MagicWave.Add();
            Feat.Wizardry.StinkyCloud.Add();
            Feat.Wizardry.Reflection.Add();
            Feat.Wizardry.Shield.Add();
            Feat.Wizardry.Fright.Add();
            Feat.Wizardry.FitOfLaughter.Add();
            Feat.Wizardry.SpellFocus.Add();
            Feat.Wizardry.MagicPower.Add();
            Feat.Wizardry.Icicle.Add();
            Feat.Wizardry.Fireball.Add();
            Feat.Wizardry.HoldPerson.Add();
            Feat.Wizardry.Metamagic.Add();
            Feat.Wizardry.ImprovedMagicWave.Add();
            Feat.Wizardry.SpellFocus2.Add();
            Feat.Wizardry.MagicPower2.Add();
            Feat.Wizardry.Chronos.Add();
            Feat.Wizardry.Dionysos.Add();
            Feat.Wizardry.Thanos.Add();
        }

        private static void AddWonderData() {
            Feat.Wonder.IceArmor.Add();
            Feat.Wonder.MagicWeapon.Add();
            Feat.Wonder.MiracleDoll.Add();
            Feat.Wonder.ThingT.Add();
            Feat.Wonder.Haste.Add();
            Feat.Wonder.Lubricate.Add();
            Feat.Wonder.MiracleFocus.Add();
            Feat.Wonder.MiraculousPower.Add();
            Feat.Wonder.DiamondArmor.Add();
            Feat.Wonder.AccurateWeapon.Add();
            Feat.Wonder.ChannelingNegativeEnergy.Add();
            Feat.Wonder.Mob.Add();
            Feat.Wonder.Brains.Add();
            Feat.Wonder.MiracleFocus2.Add();
            Feat.Wonder.MiraculousPower2.Add();
            Feat.Wonder.Tartaros.Add();
            Feat.Wonder.Nyx.Add();
            Feat.Wonder.Styx.Add();
        }
        #endregion

        #region Profession
        private static void AddSmithingData() {
            Profession.Smithing.Sharpen.Add();
            Profession.Smithing.Hardening.Add();
            Profession.Smithing.Refining.Add();
            Profession.Smithing.RaisePower.Add();
            Profession.Smithing.CreateBoots.Add();
            Profession.Smithing.Upgrading.Add();
            Profession.Smithing.InefficientSmithing.Add();
            Profession.Smithing.EfficientSmithing.Add();
            Profession.Smithing.ElementalDamage.Add();
            Profession.Smithing.ElementalArmor.Add();
            Profession.Smithing.Enlarge.Add();
            Profession.Smithing.InefficientSmithing2.Add();
            Profession.Smithing.EfficientSmithing2.Add();
            Profession.Smithing.Mastersmith.Add();
            Profession.Smithing.WitchSmithy.Add();
        }
        #endregion

        #region Skill
        private static void AddSkillGroupData() {
            Skill.Group.Dungeon.Add();
            Skill.Group.Fight.Add();
        }

        private static void AddSkillTypeData() {
            Skill.Type.Detection.Add();
            Skill.Type.Trap.Add();
        }
        #endregion

        #region Item
        private static void AddEffectData() {
            Item.Effect.Primary.Add();
            Item.Effect.Secondary.Add();
        }

        private static void AddItemData() {
            Item.Item.ArmorFighter1.Add();
            Item.Item.ArmorClreic1.Add();
            Item.Item.ArmorRogue1.Add();
            Item.Item.ArmorMage1.Add();
        }

        private static void AddItemQualityData() {
            Item.ItemQuality.Rusty.Add();
            Item.ItemQuality.Notched.Add();
            Item.ItemQuality.Normal.Add();
            Item.ItemQuality.Hardened.Add();
            Item.ItemQuality.Masterwork.Add();

            Api.Item.ItemQuality.Singleton.Get(nameof(Item.ItemQuality.Rusty)).AddUpgrade(nameof(Item.ItemQuality.Notched));
            Api.Item.ItemQuality.Singleton.Get(nameof(Item.ItemQuality.Notched)).AddDownAndUpgrade(nameof(Item.ItemQuality.Rusty), nameof(Item.ItemQuality.Normal));
            Api.Item.ItemQuality.Singleton.Get(nameof(Item.ItemQuality.Normal)).AddDownAndUpgrade(nameof(Item.ItemQuality.Notched), nameof(Item.ItemQuality.Hardened));
            Api.Item.ItemQuality.Singleton.Get(nameof(Item.ItemQuality.Hardened)).AddDownAndUpgrade(nameof(Item.ItemQuality.Normal), nameof(Item.ItemQuality.Masterwork));
            Api.Item.ItemQuality.Singleton.Get(nameof(Item.ItemQuality.Masterwork)).AddDowngrade(nameof(Item.ItemQuality.Hardened));
        }

        private static void AddItemTypeData() {
            Item.ItemType.Armor.Add();
            Item.ItemType.Boots.Add();
            Item.ItemType.OneHandedWeapon.Add();
            Item.ItemType.TwoHandedWeapon.Add();
            Item.ItemType.Bow.Add();
            Item.ItemType.Crossbow.Add();
            Item.ItemType.Arrow.Add();
            Item.ItemType.Bolt.Add();
            Item.ItemType.Dagger.Add();
            Item.ItemType.Shield.Add();
            Item.ItemType.Focus.Add();
            Item.ItemType.Grimoire.Add();
            Item.ItemType.Ring.Add();
            Item.ItemType.Amulet.Add();
            Item.ItemType.Cape.Add();
            Item.ItemType.Headgear.Add();
            Item.ItemType.Bracers.Add();
            Item.ItemType.Consumable.Add();
        }
        #endregion

        #region Misc
        private static void AddRecollectionData() {
            Misc.Recollection.ReceivedSlap.Add();
            Misc.Recollection.BeenPushed.Add();
            Misc.Recollection.HittingYourself.Add();
            Misc.Recollection.DrinkSpilled.Add();
            Misc.Recollection.RippedOff.Add();
        }
        #endregion

        #region Player
        private static void AddLevelUp() {
            Player.LevelUp.Armor.Add();
            Player.LevelUp.Feat.Add();
            Player.LevelUp.Health.Add();
            Player.LevelUp.Movement.Add();
            Player.LevelUp.Skill.Add();
        }

        private static void AddPlayerClassData() {
            Player.PlayerClass.Skeleton.Add();
            Player.PlayerClass.Zombie.Add();
            Player.PlayerClass.Mummy.Add();
            Player.PlayerClass.Vampire.Add();
            Player.PlayerClass.Banshee.Add();
            Player.PlayerClass.Lich.Add();
            Player.PlayerClass.RyldsShowerWater.Add();
        }

        private static void AddSlotData() {
            Player.Slot.Body.Add();
            Player.Slot.Feet.Add();
            Player.Slot.Mainhand.Add();
            Player.Slot.Offhand.Add();
            Player.Slot.RingFingerLeft.Add();
            Player.Slot.RingFingerRight.Add();
            Player.Slot.WristLeft.Add();
            Player.Slot.WristRight.Add();
            Player.Slot.Neck.Add();
            Player.Slot.Shoulders.Add();
            Player.Slot.Head.Add();
            Player.Slot.Bag.Add();
        }
        #endregion
    }
}