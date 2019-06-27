namespace Agroservice
{
    partial class FormSignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.TextboxUsername = new MetroFramework.Controls.MetroTextBox();
            this.TextboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroComboBoxServer = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextboxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            // 
            // 
            // 
            this.TextboxUsername.CustomButton.FlatAppearance.BorderSize = 0;
            this.TextboxUsername.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextboxUsername.CustomButton.Image = null;
            this.TextboxUsername.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.TextboxUsername.CustomButton.Name = "";
            this.TextboxUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextboxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextboxUsername.CustomButton.TabIndex = 1;
            this.TextboxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextboxUsername.CustomButton.UseSelectable = true;
            this.TextboxUsername.CustomButton.Visible = false;
            this.TextboxUsername.DisplayIcon = true;
            this.TextboxUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextboxUsername.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxUsername.Icon")));
            this.TextboxUsername.Lines = new string[0];
            this.TextboxUsername.Location = new System.Drawing.Point(65, 362);
            this.TextboxUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TextboxUsername.MaxLength = 32767;
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.PasswordChar = '\0';
            this.TextboxUsername.PromptText = "Felhasználónév";
            this.TextboxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextboxUsername.SelectedText = "";
            this.TextboxUsername.SelectionLength = 0;
            this.TextboxUsername.SelectionStart = 0;
            this.TextboxUsername.ShortcutsEnabled = true;
            this.TextboxUsername.Size = new System.Drawing.Size(236, 30);
            this.TextboxUsername.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TextboxUsername.TabIndex = 6;
            this.TextboxUsername.UseSelectable = true;
            this.TextboxUsername.WaterMark = "Felhasználónév";
            this.TextboxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextboxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextboxPassword
            // 
            // 
            // 
            // 
            this.TextboxPassword.CustomButton.Image = null;
            this.TextboxPassword.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.TextboxPassword.CustomButton.Name = "";
            this.TextboxPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextboxPassword.CustomButton.TabIndex = 1;
            this.TextboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextboxPassword.CustomButton.UseSelectable = true;
            this.TextboxPassword.CustomButton.Visible = false;
            this.TextboxPassword.DisplayIcon = true;
            this.TextboxPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextboxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxPassword.Icon")));
            this.TextboxPassword.Lines = new string[0];
            this.TextboxPassword.Location = new System.Drawing.Point(65, 413);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TextboxPassword.MaxLength = 32767;
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.PasswordChar = '●';
            this.TextboxPassword.PromptText = "Jelszó";
            this.TextboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextboxPassword.SelectedText = "";
            this.TextboxPassword.SelectionLength = 0;
            this.TextboxPassword.SelectionStart = 0;
            this.TextboxPassword.ShortcutsEnabled = true;
            this.TextboxPassword.Size = new System.Drawing.Size(236, 30);
            this.TextboxPassword.Style = MetroFramework.MetroColorStyle.Brown;
            this.TextboxPassword.TabIndex = 7;
            this.TextboxPassword.UseSelectable = true;
            this.TextboxPassword.UseSystemPasswordChar = true;
            this.TextboxPassword.WaterMark = "Jelszó";
            this.TextboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(111, 477);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(148, 51);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Bejelentkezés";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // metroComboBoxServer
            // 
            this.metroComboBoxServer.FormattingEnabled = true;
            this.metroComboBoxServer.ItemHeight = 23;
            this.metroComboBoxServer.Items.AddRange(new object[] {
            "Otthoni szerver",
            "Iskolai szerver"});
            this.metroComboBoxServer.Location = new System.Drawing.Point(65, 300);
            this.metroComboBoxServer.Name = "metroComboBoxServer";
            this.metroComboBoxServer.Size = new System.Drawing.Size(236, 29);
            this.metroComboBoxServer.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBoxServer.TabIndex = 10;
            this.metroComboBoxServer.UseSelectable = true;
            this.metroComboBoxServer.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxServer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Szerver:";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroComboBoxServer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUsername);
            this.Name = "FormSignIn";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroTextBox TextboxUsername;
        public MetroFramework.Controls.MetroTextBox TextboxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxServer;
        private System.Windows.Forms.Label label1;
    }
}

