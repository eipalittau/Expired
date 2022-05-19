using Exp.Api.Player;
using Exp.Core;

namespace Exp.Test {
    public partial class frmMain : Form {
        private Main ExpiredApi { get; init; }
        private CharacterSheet? Character { get; set; }

        public frmMain() {
            InitializeComponent();

            ExpiredApi = new Api.Main(Util.LanguageEnum.Deutsch, false);
        }

        private void Form1_Load(object sender, EventArgs e) {
            ExpiredApi.SetLanguage(Util.LanguageEnum.Deutsch);
            ExpiredApi.SetExperience4LevelUp(4);

            Internal.Mod.ModHandler.Singleton.LoadList(typeof(IMain));
        }

        private void btnSelectMods_Click(object sender, EventArgs e) {
            new frmModList().Show(this);
        }

        private void btnInitialize_Click(object sender, EventArgs e) {
            Internal.Mod.ModHandler.Singleton.InitializeActiveMods();
        }

        private void btnNewCharacter_Click(object sender, EventArgs e) {
            frmFeatList lFeatForm = new();
            Character = ExpiredApi.CreateCharacter();

            lFeatForm.AuraList(Character.Feat.Aura.EnumerateUnused());

            if (lFeatForm.ShowDialog(this) == DialogResult.OK) {

            }
        }
    }
}