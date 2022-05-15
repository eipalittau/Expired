using System.Reflection;

namespace Exp.Test {
    public partial class Form1 : Form {
        private Api.Main ExpiredApi { get; init; }

        public Form1() {
            InitializeComponent();

            ExpiredApi = new Api.Main(false, Util.LanguageEnum.Deutsch);
        }

        private void Form1_Load(object sender, EventArgs e) {
            Util.ExceptionHandler.ThrowException = false;
            Util.ModHandler lModHandler = new("MODS", "ModSort.json");

            //lModList.ForEach(x => x.IsActive = true);
            //lModHandler.LoadMods(lModList, typeof(IMain));

            Util.ExceptionHandler.ThrowException = true;

            ExpiredApi.SetLanguage(Util.LanguageEnum.Deutsch);
            ExpiredApi.SetExperience4LevelUp(4);
            ExpiredApi.CreateCharacter();
        }
    }
}