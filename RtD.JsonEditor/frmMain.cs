using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RtD.JsonEditor {
    public partial class frmMain : Form {
        private FileInfo PathFile { get; set; }
        public frmMain() {
            InitializeComponent();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e) {
            using (OpenFileDialog lOpenFileDialog = new OpenFileDialog()) {
                lOpenFileDialog.InitialDirectory = @"C:\";
                lOpenFileDialog.Filter = "Json files (*.json)|*.json|Alle files (*.*)|*.*";
                lOpenFileDialog.FilterIndex = 1;
                lOpenFileDialog.RestoreDirectory = true;

                if (lOpenFileDialog.ShowDialog() == DialogResult.OK) {
                    PathFile = new FileInfo(lOpenFileDialog.FileName);

                    using (StreamReader lReader = new StreamReader(lOpenFileDialog.OpenFile())) {
                        LoadJson(lReader.ReadToEnd());
                    }
                }
            }
        }

        private void mnuFileQuit_Click(object sender, EventArgs e) {
            Close();
        }

        private void LoadJson(string aJsonContent) {
            object? lJson = JsonConvert.DeserializeObject(aJsonContent);

            if (lJson != null) {
                var x = ((JObject)lJson).First;
                
            }
        }
    }
}