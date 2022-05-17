﻿using Exp.Util.Extension;

namespace Exp.Test {
    public partial class frmModList : Form {
        public frmModList() {
            InitializeComponent();
        }

        private void frmModList_Load(object sender, EventArgs e) {
            Util.ModHandler.Singleton.GetList().ForEach(x => checkedListBox1.Items.Add(x.Name, x.IsActive));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (sender is CheckedListBox aObject) {
                textBox1.Text = Util.ModHandler.Singleton.GetItem(aObject.SelectedItem.Null2String())
                    .GetFullDescription();
            } else {
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            Util.ModHandler.Singleton.Save();
            Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (sender is CheckedListBox aObject && !aObject.SelectedItem.Null2String().Equals(string.Empty)) {
                Util.ModHandler.Singleton.GetItem(aObject.SelectedItem.Null2String()).IsActive = e.NewValue == CheckState.Checked;
            }
        }
    }
}
