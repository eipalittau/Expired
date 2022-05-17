using Exp.Api.Player;

namespace Exp.Test {
    public partial class frmMain : Form {
        private Api.Main ExpiredApi { get; init; }

        public frmMain() {
            InitializeComponent();

            Util.ExceptionHandler.ThrowException = false;
            ExpiredApi = new Api.Main(false, Util.LanguageEnum.Deutsch);
        }

        private void Form1_Load(object sender, EventArgs e) {
            ExpiredApi.SetLanguage(Util.LanguageEnum.Deutsch);
            ExpiredApi.SetExperience4LevelUp(4);

            Util.ModHandler.Singleton.LoadList(typeof(IMain));
        }

        private void button1_Click(object sender, EventArgs e) {
            new frmModList().Show(this);
        }

        private void button2_Click(object sender, EventArgs e) {
            Util.ModHandler.Singleton.InitializeActiveMods();
        }

        private void button3_Click(object sender, EventArgs e) {
            frmFeatList lFeatForm = new();
            CharacterSheet lCharacter = ExpiredApi.CreateCharacter();

            if (lFeatForm.ShowDialog(this) == DialogResult.OK) {

            }

            //lCharacter.LevelUp();
        }
    }
}