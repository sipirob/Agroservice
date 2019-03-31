﻿namespace Agroservice
{
    partial class UserControlWorkerClientData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlWorkerClientData));
            this.listViewClientData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextboxClientName = new MetroFramework.Controls.MetroTextBox();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.errorProviderNameFirstLetterLover = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameFirstLetterLover)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClientData
            // 
            this.listViewClientData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listViewClientData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewClientData.FullRowSelect = true;
            this.listViewClientData.GridLines = true;
            this.listViewClientData.Location = new System.Drawing.Point(0, 0);
            this.listViewClientData.Name = "listViewClientData";
            this.listViewClientData.Size = new System.Drawing.Size(721, 612);
            this.listViewClientData.TabIndex = 1;
            this.listViewClientData.UseCompatibleStateImageBehavior = false;
            this.listViewClientData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "név";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "lakhely";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "telefonszám";
            this.columnHeader4.Width = 200;
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
            this.TextboxClientName.CustomButton.Location = new System.Drawing.Point(284, 2);
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
            this.TextboxClientName.Location = new System.Drawing.Point(14, 30);
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
            this.TextboxClientName.Size = new System.Drawing.Size(312, 30);
            this.TextboxClientName.Style = MetroFramework.MetroColorStyle.Brown;
            this.TextboxClientName.TabIndex = 7;
            this.TextboxClientName.UseSelectable = true;
            this.TextboxClientName.WaterMark = "Ügyfél neve";
            this.TextboxClientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextboxClientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.FlatAppearance.BorderSize = 0;
            this.buttonSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchClient.Location = new System.Drawing.Point(3, 101);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(338, 56);
            this.buttonSearchClient.TabIndex = 8;
            this.buttonSearchClient.Text = "Keresés";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // errorProviderNameFirstLetterLover
            // 
            this.errorProviderNameFirstLetterLover.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.TextboxClientName);
            this.panel1.Controls.Add(this.buttonSearchClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(718, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 612);
            this.panel1.TabIndex = 9;
            // 
            // UserControlWorkerClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewClientData);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlWorkerClientData";
            this.Size = new System.Drawing.Size(1062, 612);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameFirstLetterLover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listViewClientData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public MetroFramework.Controls.MetroTextBox TextboxClientName;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.ErrorProvider errorProviderNameFirstLetterLover;
        private System.Windows.Forms.Panel panel1;
    }
}
