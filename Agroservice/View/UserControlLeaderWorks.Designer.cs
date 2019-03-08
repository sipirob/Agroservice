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
            this.dataGridViewAllNewWorks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBoxWorkers = new MetroFramework.Controls.MetroComboBox();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
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
            this.dataGridViewAllNewWorks.Size = new System.Drawing.Size(676, 439);
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
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
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
            this.metroComboBoxWorkers.Location = new System.Drawing.Point(718, 62);
            this.metroComboBoxWorkers.Name = "metroComboBoxWorkers";
            this.metroComboBoxWorkers.Size = new System.Drawing.Size(293, 29);
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
            this.dataGridViewAllCompleteWorks.Size = new System.Drawing.Size(717, 458);
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
    }
}
