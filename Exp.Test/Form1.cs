using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Exp.Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Exp.Api.Main.Singleton.Initialize();

            throw new Exp.Exception.DiceNotFoundException(11);
            
        }
    }
}