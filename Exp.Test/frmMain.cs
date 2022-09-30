using Exp.Core;
using Exp.Util.Enumeration;

namespace Exp.Test
{
    public partial class frmMain : Form {
        private List<CharacterSheet> CharacterList { get; } = new();
        private int Experience4LevelUp { get; } = 4;

        public frmMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Util.Localisation.Language = LanguageEnum.Deutsch;
            Util.ExceptionHandler.ThrowException = false;
        }

        private void btnSelectMods_Click(object sender, EventArgs e) {
            new frmModList().Show(this);
        }

        private void btnInitialize_Click(object sender, EventArgs e) {
            Core.Mod.ModHandler.Singleton.InitializeActiveMods(typeof(IMain));
        }

        private void btnNewCharacter_Click(object sender, EventArgs e) {
            CharacterSheet lSheet = CharacterSheet.Create(Experience4LevelUp);
            frmFeatList lFeatForm = new(lSheet);

            CharacterList.Add(lSheet);

            if (lFeatForm.ShowDialog(this) == DialogResult.OK) {
                //lSheet.LevelUp(aFeatTalents: null, aSkills: null);
            }
        }
    }
}