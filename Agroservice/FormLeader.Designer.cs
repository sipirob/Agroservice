namespace Agroservice
{
    partial class FormLeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSign = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonUsersData = new System.Windows.Forms.Button();
            this.buttonNewWork = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelIsWorks = new System.Windows.Forms.Label();
            this.labelNoworks = new System.Windows.Forms.Label();
            this.userControlLeaderSettings1 = new Agroservice.View.UserControlLeaderSettings();
            this.userControlLeaderWorks1 = new Agroservice.UserControlLeaderWorks();
            this.userControlLeaderClientsData1 = new Agroservice.UserControlLeaderClientsData();
            this.userControlLeaderAllNewWorks1 = new Agroservice.UserControlLeaderWorks();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 80);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(1089, 43);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(145, 21);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Felhasználó Neve";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panelSign);
            this.panel2.Controls.Add(this.buttonHome);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.buttonSettings);
            this.panel2.Controls.Add(this.buttonUsersData);
            this.panel2.Controls.Add(this.buttonNewWork);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 601);
            this.panel2.TabIndex = 3;
            // 
            // panelSign
            // 
            this.panelSign.BackColor = System.Drawing.Color.Chartreuse;
            this.panelSign.Location = new System.Drawing.Point(3, -1);
            this.panelSign.Name = "panelSign";
            this.panelSign.Size = new System.Drawing.Size(12, 88);
            this.panelSign.TabIndex = 7;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, -1);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(202, 86);
            this.buttonHome.TabIndex = 8;
            this.buttonHome.Text = "Főoldal";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 460);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 86);
            this.button5.TabIndex = 7;
            this.button5.Text = "Névjegy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(0, 274);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(202, 86);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Beállítások";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonUsersData
            // 
            this.buttonUsersData.FlatAppearance.BorderSize = 0;
            this.buttonUsersData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsersData.ForeColor = System.Drawing.Color.White;
            this.buttonUsersData.Location = new System.Drawing.Point(0, 180);
            this.buttonUsersData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUsersData.Name = "buttonUsersData";
            this.buttonUsersData.Size = new System.Drawing.Size(202, 86);
            this.buttonUsersData.TabIndex = 5;
            this.buttonUsersData.Text = "Felhasználók";
            this.buttonUsersData.UseVisualStyleBackColor = true;
            this.buttonUsersData.Click += new System.EventHandler(this.buttonUsersData_Click);
            // 
            // buttonNewWork
            // 
            this.buttonNewWork.FlatAppearance.BorderSize = 0;
            this.buttonNewWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewWork.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewWork.ForeColor = System.Drawing.Color.White;
            this.buttonNewWork.Location = new System.Drawing.Point(0, 86);
            this.buttonNewWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewWork.Name = "buttonNewWork";
            this.buttonNewWork.Size = new System.Drawing.Size(202, 86);
            this.buttonNewWork.TabIndex = 3;
            this.buttonNewWork.Text = "Munkálatok";
            this.buttonNewWork.UseVisualStyleBackColor = true;
            this.buttonNewWork.Click += new System.EventHandler(this.buttonNewWork_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 467);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelIsWorks
            // 
            this.labelIsWorks.AutoSize = true;
            this.labelIsWorks.Location = new System.Drawing.Point(250, 90);
            this.labelIsWorks.Name = "labelIsWorks";
            this.labelIsWorks.Size = new System.Drawing.Size(57, 21);
            this.labelIsWorks.TabIndex = 10;
            this.labelIsWorks.Text = "label1";
            // 
            // labelNoworks
            // 
            this.labelNoworks.AutoSize = true;
            this.labelNoworks.Location = new System.Drawing.Point(250, 111);
            this.labelNoworks.Name = "labelNoworks";
            this.labelNoworks.Size = new System.Drawing.Size(57, 21);
            this.labelNoworks.TabIndex = 11;
            this.labelNoworks.Text = "label1";
            // 
            // userControlLeaderSettings1
            // 
            this.userControlLeaderSettings1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlLeaderSettings1.Location = new System.Drawing.Point(202, 80);
            this.userControlLeaderSettings1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlLeaderSettings1.Name = "userControlLeaderSettings1";
            this.userControlLeaderSettings1.Size = new System.Drawing.Size(1062, 601);
            this.userControlLeaderSettings1.TabIndex = 12;
            this.userControlLeaderSettings1.Load += new System.EventHandler(this.userControlLeaderSettings1_Load);
            // 
            // userControlLeaderWorks1
            // 
            this.userControlLeaderWorks1.BackColor = System.Drawing.Color.White;
            this.userControlLeaderWorks1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlLeaderWorks1.Location = new System.Drawing.Point(202, 80);
            this.userControlLeaderWorks1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlLeaderWorks1.Name = "userControlLeaderWorks1";
            this.userControlLeaderWorks1.Size = new System.Drawing.Size(1062, 601);
            this.userControlLeaderWorks1.TabIndex = 9;
            this.userControlLeaderWorks1.Load += new System.EventHandler(this.userControlLeaderWorks1_Load);
            // 
            // userControlLeaderClientsData1
            // 
            this.userControlLeaderClientsData1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlLeaderClientsData1.Location = new System.Drawing.Point(202, 80);
            this.userControlLeaderClientsData1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlLeaderClientsData1.Name = "userControlLeaderClientsData1";
            this.userControlLeaderClientsData1.Size = new System.Drawing.Size(1062, 601);
            this.userControlLeaderClientsData1.TabIndex = 8;
            // 
            // userControlLeaderAllNewWorks1
            // 
            this.userControlLeaderAllNewWorks1.BackColor = System.Drawing.Color.White;
            this.userControlLeaderAllNewWorks1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlLeaderAllNewWorks1.Location = new System.Drawing.Point(202, 79);
            this.userControlLeaderAllNewWorks1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlLeaderAllNewWorks1.Name = "userControlLeaderAllNewWorks1";
            this.userControlLeaderAllNewWorks1.Size = new System.Drawing.Size(1062, 602);
            this.userControlLeaderAllNewWorks1.TabIndex = 9;
            // 
            // FormLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.userControlLeaderSettings1);
            this.Controls.Add(this.userControlLeaderWorks1);
            this.Controls.Add(this.userControlLeaderClientsData1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNoworks);
            this.Controls.Add(this.labelIsWorks);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLeader";
            this.Text = "FormLeader";
            this.Load += new System.EventHandler(this.FormLeader_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSign;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonUsersData;
        private System.Windows.Forms.Button buttonNewWork;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlLeaderClientsData userControlLeaderClientsData1;
        private UserControlLeaderWorks userControlLeaderAllNewWorks1;
        private UserControlLeaderWorks userControlLeaderWorks1;
        private System.Windows.Forms.Label labelIsWorks;
        private System.Windows.Forms.Label labelNoworks;
        private View.UserControlLeaderSettings userControlLeaderSettings1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}