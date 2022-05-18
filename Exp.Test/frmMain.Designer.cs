namespace Exp.Test {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSelectMods = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectMods
            // 
            this.btnSelectMods.Location = new System.Drawing.Point(8, 7);
            this.btnSelectMods.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectMods.Name = "btnSelectMods";
            this.btnSelectMods.Size = new System.Drawing.Size(187, 20);
            this.btnSelectMods.TabIndex = 0;
            this.btnSelectMods.Text = "Select Mods";
            this.btnSelectMods.UseVisualStyleBackColor = true;
            this.btnSelectMods.Click += new System.EventHandler(this.btnSelectMods_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitialize.Location = new System.Drawing.Point(320, 7);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(187, 20);
            this.btnInitialize.TabIndex = 1;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCharacter.Location = new System.Drawing.Point(320, 31);
            this.btnNewCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(187, 20);
            this.btnNewCharacter.TabIndex = 2;
            this.btnNewCharacter.Text = "New Character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            this.btnNewCharacter.Click += new System.EventHandler(this.btnNewCharacter_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 250);
            this.Controls.Add(this.btnNewCharacter);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.btnSelectMods);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectMods;
        private Button btnInitialize;
        private Button btnNewCharacter;
    }
}