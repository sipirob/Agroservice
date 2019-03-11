namespace Agroservice
{
    partial class UserControlLeaderClientsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLeaderClientsData));
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewClientsData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.TextboxClientName = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonUpdateWorkerData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroWorkerBirthday = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorkerTelnumber = new System.Windows.Forms.TextBox();
            this.textBoxWorkerPlace = new System.Windows.Forms.TextBox();
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(785, 442);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(163, 53);
            this.buttonDeleteClient.TabIndex = 1;
            this.buttonDeleteClient.Text = "Ügyfél törlése";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ügyfelek adatai";
            // 
            // listViewClientsData
            // 
            this.listViewClientsData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewClientsData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewClientsData.FullRowSelect = true;
            this.listViewClientsData.GridLines = true;
            this.listViewClientsData.Location = new System.Drawing.Point(31, 54);
            this.listViewClientsData.Name = "listViewClientsData";
            this.listViewClientsData.Size = new System.Drawing.Size(531, 448);
            this.listViewClientsData.TabIndex = 3;
            this.listViewClientsData.UseCompatibleStateImageBehavior = false;
            this.listViewClientsData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "név";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "lakhely";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "telefonszám";
            this.columnHeader4.Width = 120;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Location = new System.Drawing.Point(227, 144);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Location = new System.Drawing.Point(39, 27);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(988, 540);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl2.TabIndex = 5;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.buttonSearchClient);
            this.metroTabPage1.Controls.Add(this.TextboxClientName);
            this.metroTabPage1.Controls.Add(this.label9);
            this.metroTabPage1.Controls.Add(this.buttonDeleteClient);
            this.metroTabPage1.Controls.Add(this.listViewClientsData);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(980, 498);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Ügyfelek";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(826, 110);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(122, 40);
            this.buttonSearchClient.TabIndex = 11;
            this.buttonSearchClient.Text = "Keresés";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // TextboxClientName
            // 
            this.TextboxClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextboxClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            // 
            // 
            // 
            this.TextboxClientName.CustomButton.FlatAppearance.BorderSize = 0;
            this.TextboxClientName.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextboxClientName.CustomButton.Image = null;
            this.TextboxClientName.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.TextboxClientName.CustomButton.Name = "";
            this.TextboxClientName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextboxClientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextboxClientName.CustomButton.TabIndex = 1;
            this.TextboxClientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextboxClientName.CustomButton.UseSelectable = true;
            this.TextboxClientName.CustomButton.Visible = false;
            this.TextboxClientName.DisplayIcon = true;
            this.TextboxClientName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextboxClientName.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxClientName.Icon")));
            this.TextboxClientName.Lines = new string[0];
            this.TextboxClientName.Location = new System.Drawing.Point(712, 54);
            this.TextboxClientName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TextboxClientName.MaxLength = 32767;
            this.TextboxClientName.Name = "TextboxClientName";
            this.TextboxClientName.PasswordChar = '\0';
            this.TextboxClientName.PromptText = "Ügyfél neve";
            this.TextboxClientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextboxClientName.SelectedText = "";
            this.TextboxClientName.SelectionLength = 0;
            this.TextboxClientName.SelectionStart = 0;
            this.TextboxClientName.ShortcutsEnabled = true;
            this.TextboxClientName.Size = new System.Drawing.Size(236, 30);
            this.TextboxClientName.Style = MetroFramework.MetroColorStyle.Brown;
            this.TextboxClientName.TabIndex = 10;
            this.TextboxClientName.UseSelectable = true;
            this.TextboxClientName.WaterMark = "Ügyfél neve";
            this.TextboxClientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextboxClientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ügyfél keresése:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.buttonLoad);
            this.metroTabPage2.Controls.Add(this.button4);
            this.metroTabPage2.Controls.Add(this.button3);
            this.metroTabPage2.Controls.Add(this.buttonUpdateWorkerData);
            this.metroTabPage2.Controls.Add(this.button1);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.listBoxWorkers);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(980, 498);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Dolgozók";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(843, 186);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(121, 67);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Betölt";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(843, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 67);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ment";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(843, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 67);
            this.button3.TabIndex = 7;
            this.button3.Text = "Töröl";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUpdateWorkerData
            // 
            this.buttonUpdateWorkerData.Location = new System.Drawing.Point(843, 96);
            this.buttonUpdateWorkerData.Name = "buttonUpdateWorkerData";
            this.buttonUpdateWorkerData.Size = new System.Drawing.Size(121, 67);
            this.buttonUpdateWorkerData.TabIndex = 6;
            this.buttonUpdateWorkerData.Text = "Módosít";
            this.buttonUpdateWorkerData.UseVisualStyleBackColor = true;
            this.buttonUpdateWorkerData.Click += new System.EventHandler(this.buttonUpdateWorkerData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Új";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.metroWorkerBirthday);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxWorkerTelnumber);
            this.groupBox2.Controls.Add(this.textBoxWorkerPlace);
            this.groupBox2.Controls.Add(this.textBoxWorkerName);
            this.groupBox2.Location = new System.Drawing.Point(300, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 262);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Személyes adatok";
            // 
            // metroWorkerBirthday
            // 
            this.metroWorkerBirthday.Location = new System.Drawing.Point(172, 91);
            this.metroWorkerBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroWorkerBirthday.Name = "metroWorkerBirthday";
            this.metroWorkerBirthday.Size = new System.Drawing.Size(201, 29);
            this.metroWorkerBirthday.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefonszám:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lakhely:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Születési idő:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Név:";
            // 
            // textBoxWorkerTelnumber
            // 
            this.textBoxWorkerTelnumber.Location = new System.Drawing.Point(172, 184);
            this.textBoxWorkerTelnumber.Name = "textBoxWorkerTelnumber";
            this.textBoxWorkerTelnumber.Size = new System.Drawing.Size(201, 27);
            this.textBoxWorkerTelnumber.TabIndex = 4;
            // 
            // textBoxWorkerPlace
            // 
            this.textBoxWorkerPlace.Location = new System.Drawing.Point(172, 138);
            this.textBoxWorkerPlace.Name = "textBoxWorkerPlace";
            this.textBoxWorkerPlace.Size = new System.Drawing.Size(201, 27);
            this.textBoxWorkerPlace.TabIndex = 3;
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.Location = new System.Drawing.Point(172, 43);
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.Size = new System.Drawing.Size(201, 27);
            this.textBoxWorkerName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(300, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belépési adatok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jogosultság:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jelszó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "felhasználónév:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(172, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 27);
            this.textBox7.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 27);
            this.textBox1.TabIndex = 0;
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.ItemHeight = 21;
            this.listBoxWorkers.Location = new System.Drawing.Point(12, 14);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(227, 445);
            this.listBoxWorkers.TabIndex = 2;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkers_SelectedIndexChanged);
            // 
            // UserControlLeaderClientsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlLeaderClientsData";
            this.Size = new System.Drawing.Size(1062, 612);
            this.Load += new System.EventHandler(this.UserControlLeaderClientsData_Load);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listViewClientsData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonUpdateWorkerData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWorkerTelnumber;
        private System.Windows.Forms.TextBox textBoxWorkerPlace;
        private System.Windows.Forms.TextBox textBoxWorkerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.Button buttonSearchClient;
        public MetroFramework.Controls.MetroTextBox TextboxClientName;
        private System.Windows.Forms.Label label9;
        public MetroFramework.Controls.MetroDateTime metroWorkerBirthday;
        private System.Windows.Forms.Button buttonLoad;
    }
}
