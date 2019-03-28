namespace Agroservice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLeaderWorks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAllNewWorks = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewAllCompleteWorks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllNewWorks)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCompleteWorks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllNewWorks
            // 
            this.dataGridViewAllNewWorks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewAllNewWorks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAllNewWorks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAllNewWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllNewWorks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllNewWorks.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewAllNewWorks.Name = "dataGridViewAllNewWorks";
            this.dataGridViewAllNewWorks.Size = new System.Drawing.Size(755, 555);
            this.dataGridViewAllNewWorks.TabIndex = 0;
            this.dataGridViewAllNewWorks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllNewWorks_CellContentClick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(120, 50);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1062, 612);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.dataGridViewAllNewWorks);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 54);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1054, 554);
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
            this.metroComboBoxWorkers.Location = new System.Drawing.Point(3, 27);
            this.metroComboBoxWorkers.Name = "metroComboBoxWorkers";
            this.metroComboBoxWorkers.Size = new System.Drawing.Size(287, 29);
            this.metroComboBoxWorkers.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBoxWorkers.TabIndex = 3;
            this.metroComboBoxWorkers.UseSelectable = true;
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAddWorker.FlatAppearance.BorderSize = 0;
            this.buttonAddWorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWorker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddWorker.Location = new System.Drawing.Point(0, 115);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(294, 51);
            this.buttonAddWorker.TabIndex = 2;
            this.buttonAddWorker.Text = "Dolgozó hozzáadása";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.dataGridViewAllCompleteWorks);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 54);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1054, 554);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Elkészült munkálatok";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // buttonSearchBoth
            // 
            this.buttonSearchBoth.FlatAppearance.BorderSize = 0;
            this.buttonSearchBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchBoth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchBoth.Location = new System.Drawing.Point(3, 474);
            this.buttonSearchBoth.Name = "buttonSearchBoth";
            this.buttonSearchBoth.Size = new System.Drawing.Size(194, 46);
            this.buttonSearchBoth.TabIndex = 13;
            this.buttonSearchBoth.Text = "Komplex keresés";
            this.buttonSearchBoth.UseVisualStyleBackColor = true;
            this.buttonSearchBoth.Click += new System.EventHandler(this.buttonSearchBoth_Click);
            // 
            // buttonSearchWorker
            // 
            this.buttonSearchWorker.FlatAppearance.BorderSize = 0;
            this.buttonSearchWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchWorker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchWorker.Location = new System.Drawing.Point(3, 413);
            this.buttonSearchWorker.Name = "buttonSearchWorker";
            this.buttonSearchWorker.Size = new System.Drawing.Size(194, 55);
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
            this.TextboxClient.CustomButton.Location = new System.Drawing.Point(166, 2);
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
            this.TextboxClient.Location = new System.Drawing.Point(3, 19);
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
            this.TextboxClient.Size = new System.Drawing.Size(194, 30);
            this.TextboxClient.Style = MetroFramework.MetroColorStyle.Silver;
            this.TextboxClient.TabIndex = 11;
            this.TextboxClient.UseSelectable = true;
            this.TextboxClient.WaterMark = "Ügyfél neve";
            this.TextboxClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextboxClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.FlatAppearance.BorderSize = 0;
            this.buttonSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchClient.Location = new System.Drawing.Point(3, 361);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(194, 46);
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
            this.metroComboBoxWorker.Location = new System.Drawing.Point(3, 69);
            this.metroComboBoxWorker.Name = "metroComboBoxWorker";
            this.metroComboBoxWorker.Size = new System.Drawing.Size(194, 29);
            this.metroComboBoxWorker.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBoxWorker.TabIndex = 4;
            this.metroComboBoxWorker.UseSelectable = true;
            // 
            // dataGridViewAllCompleteWorks
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAllCompleteWorks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAllCompleteWorks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAllCompleteWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCompleteWorks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllCompleteWorks.Name = "dataGridViewAllCompleteWorks";
            this.dataGridViewAllCompleteWorks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllCompleteWorks.Size = new System.Drawing.Size(851, 554);
            this.dataGridViewAllCompleteWorks.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.metroComboBoxWorkers);
            this.panel1.Controls.Add(this.buttonAddWorker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(761, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 554);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.TextboxClient);
            this.panel2.Controls.Add(this.metroComboBoxWorker);
            this.panel2.Controls.Add(this.buttonSearchClient);
            this.panel2.Controls.Add(this.buttonSearchBoth);
            this.panel2.Controls.Add(this.buttonSearchWorker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(854, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 554);
            this.panel2.TabIndex = 14;
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
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCompleteWorks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewAllNewWorks;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button buttonAddWorker;
        public System.Windows.Forms.DataGridView dataGridViewAllCompleteWorks;
        public MetroFramework.Controls.MetroComboBox metroComboBoxWorkers;
        private System.Windows.Forms.Button buttonSearchClient;
        public MetroFramework.Controls.MetroTextBox TextboxClient;
        public MetroFramework.Controls.MetroComboBox metroComboBoxWorker;
        private System.Windows.Forms.Button buttonSearchWorker;
        private System.Windows.Forms.Button buttonSearchBoth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
