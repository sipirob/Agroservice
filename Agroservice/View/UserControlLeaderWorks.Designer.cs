﻿namespace Agroservice
{
    partial class UserControlLeaderWorks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLeaderWorks));
            this.dataGridViewAllNewWorks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBoxWorkers = new MetroFramework.Controls.MetroComboBox();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonSearchBoth = new System.Windows.Forms.Button();
            this.buttonSearchWorker = new System.Windows.Forms.Button();
            this.TextboxClient = new MetroFramework.Controls.MetroTextBox();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.metroComboBoxWorker = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAllCompleteWorks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllNewWorks)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCompleteWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllNewWorks
            // 
            this.dataGridViewAllNewWorks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewAllNewWorks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewAllNewWorks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAllNewWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllNewWorks.Location = new System.Drawing.Point(7, 62);
            this.dataGridViewAllNewWorks.Name = "dataGridViewAllNewWorks";
            this.dataGridViewAllNewWorks.Size = new System.Drawing.Size(705, 439);
            this.dataGridViewAllNewWorks.TabIndex = 0;
            this.dataGridViewAllNewWorks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllNewWorks_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Újonnan beérkezett munkálatok:";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(120, 50);
            this.metroTabControl1.Location = new System.Drawing.Point(25, 15);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1022, 581);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroTabPage1.Controls.Add(this.metroComboBoxWorkers);
            this.metroTabPage1.Controls.Add(this.buttonAddWorker);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.dataGridViewAllNewWorks);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 54);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1014, 523);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Új munkálatok";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            // 
            // metroComboBoxWorkers
            // 
            this.metroComboBoxWorkers.FormattingEnabled = true;
            this.metroComboBoxWorkers.ItemHeight = 23;
            this.metroComboBoxWorkers.Location = new System.Drawing.Point(736, 62);
            this.metroComboBoxWorkers.Name = "metroComboBoxWorkers";
            this.metroComboBoxWorkers.Size = new System.Drawing.Size(275, 29);
            this.metroComboBoxWorkers.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxWorkers.TabIndex = 3;
            this.metroComboBoxWorkers.UseSelectable = true;
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Location = new System.Drawing.Point(861, 450);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(139, 51);
            this.buttonAddWorker.TabIndex = 2;
            this.buttonAddWorker.Text = "Dolgozó hozzáadása";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.buttonSearchBoth);
            this.metroTabPage2.Controls.Add(this.buttonSearchWorker);
            this.metroTabPage2.Controls.Add(this.TextboxClient);
            this.metroTabPage2.Controls.Add(this.buttonSearchClient);
            this.metroTabPage2.Controls.Add(this.metroComboBoxWorker);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.dataGridViewAllCompleteWorks);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 54);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1014, 523);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Elkészült munkálatok";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // buttonSearchBoth
            // 
            this.buttonSearchBoth.Location = new System.Drawing.Point(792, 369);
            this.buttonSearchBoth.Name = "buttonSearchBoth";
            this.buttonSearchBoth.Size = new System.Drawing.Size(210, 46);
            this.buttonSearchBoth.TabIndex = 13;
            this.buttonSearchBoth.Text = "Komplex keresés";
            this.buttonSearchBoth.UseVisualStyleBackColor = true;
            this.buttonSearchBoth.Click += new System.EventHandler(this.buttonSearchBoth_Click);
            // 
            // buttonSearchWorker
            // 
            this.buttonSearchWorker.Location = new System.Drawing.Point(792, 284);
            this.buttonSearchWorker.Name = "buttonSearchWorker";
            this.buttonSearchWorker.Size = new System.Drawing.Size(210, 46);
            this.buttonSearchWorker.TabIndex = 12;
            this.buttonSearchWorker.Text = "Keresés dolgozó alapján";
            this.buttonSearchWorker.UseVisualStyleBackColor = true;
            this.buttonSearchWorker.Click += new System.EventHandler(this.buttonSearchWorker_Click);
            // 
            // TextboxClient
            // 
            this.TextboxClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextboxClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            // 
            // 
            // 
            this.TextboxClient.CustomButton.FlatAppearance.BorderSize = 0;
            this.TextboxClient.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextboxClient.CustomButton.Image = null;
            this.TextboxClient.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.TextboxClient.CustomButton.Name = "";
            this.TextboxClient.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextboxClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextboxClient.CustomButton.TabIndex = 1;
            this.TextboxClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextboxClient.CustomButton.UseSelectable = true;
            this.TextboxClient.CustomButton.Visible = false;
            this.TextboxClient.DisplayIcon = true;
            this.TextboxClient.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextboxClient.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxClient.Icon")));
            this.TextboxClient.Lines = new string[0];
            this.TextboxClient.Location = new System.Drawing.Point(792, 49);
            this.TextboxClient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TextboxClient.MaxLength = 32767;
            this.TextboxClient.Name = "TextboxClient";
            this.TextboxClient.PasswordChar = '\0';
            this.TextboxClient.PromptText = "Ügyfél neve";
            this.TextboxClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextboxClient.SelectedText = "";
            this.TextboxClient.SelectionLength = 0;
            this.TextboxClient.SelectionStart = 0;
            this.TextboxClient.ShortcutsEnabled = true;
            this.TextboxClient.Size = new System.Drawing.Size(210, 30);
            this.TextboxClient.Style = MetroFramework.MetroColorStyle.Lime;
            this.TextboxClient.TabIndex = 11;
            this.TextboxClient.UseSelectable = true;
            this.TextboxClient.WaterMark = "Ügyfél neve";
            this.TextboxClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextboxClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(792, 219);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(210, 46);
            this.buttonSearchClient.TabIndex = 6;
            this.buttonSearchClient.Text = "Keresés ügyfél alapján";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroComboBoxWorker
            // 
            this.metroComboBoxWorker.FormattingEnabled = true;
            this.metroComboBoxWorker.ItemHeight = 23;
            this.metroComboBoxWorker.Items.AddRange(new object[] {
            "Üres"});
            this.metroComboBoxWorker.Location = new System.Drawing.Point(792, 117);
            this.metroComboBoxWorker.Name = "metroComboBoxWorker";
            this.metroComboBoxWorker.Size = new System.Drawing.Size(210, 29);
            this.metroComboBoxWorker.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxWorker.TabIndex = 4;
            this.metroComboBoxWorker.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elkészült munkálatok:";
            // 
            // dataGridViewAllCompleteWorks
            // 
            this.dataGridViewAllCompleteWorks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAllCompleteWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCompleteWorks.Location = new System.Drawing.Point(3, 49);
            this.dataGridViewAllCompleteWorks.Name = "dataGridViewAllCompleteWorks";
            this.dataGridViewAllCompleteWorks.Size = new System.Drawing.Size(783, 458);
            this.dataGridViewAllCompleteWorks.TabIndex = 2;
            // 
            // UserControlLeaderWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlLeaderWorks";
            this.Size = new System.Drawing.Size(1062, 612);
            this.Load += new System.EventHandler(this.UserControlLeaderWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllNewWorks)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCompleteWorks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewAllNewWorks;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewAllCompleteWorks;
        public MetroFramework.Controls.MetroComboBox metroComboBoxWorkers;
        private System.Windows.Forms.Button buttonSearchClient;
        public MetroFramework.Controls.MetroTextBox TextboxClient;
        public MetroFramework.Controls.MetroComboBox metroComboBoxWorker;
        private System.Windows.Forms.Button buttonSearchWorker;
        private System.Windows.Forms.Button buttonSearchBoth;
    }
}
