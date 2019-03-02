namespace Agroservice
{
    partial class FormWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSign = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonClientData = new System.Windows.Forms.Button();
            this.buttonDoneWork = new System.Windows.Forms.Button();
            this.buttonNewWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNewWorkNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlWorkerClientData1 = new Agroservice.UserControlWorkerClientData();
            this.userControlCompleteWorks1 = new Agroservice.UserControlWorkerCompleteWorks();
            this.userControlNewWorks1 = new Agroservice.UserControlNewWorks();
            this.panelIsWork = new System.Windows.Forms.Panel();
            this.panelNoWork = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelIsWork.SuspendLayout();
            this.panelNoWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 80);
            this.panel1.TabIndex = 1;
           
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
            this.panel2.Controls.Add(this.buttonClientData);
            this.panel2.Controls.Add(this.buttonDoneWork);
            this.panel2.Controls.Add(this.buttonNewWork);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 601);
            this.panel2.TabIndex = 2;
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 367);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(202, 86);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Beállítások";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonClientData
            // 
            this.buttonClientData.FlatAppearance.BorderSize = 0;
            this.buttonClientData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClientData.ForeColor = System.Drawing.Color.White;
            this.buttonClientData.Location = new System.Drawing.Point(0, 273);
            this.buttonClientData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClientData.Name = "buttonClientData";
            this.buttonClientData.Size = new System.Drawing.Size(202, 86);
            this.buttonClientData.TabIndex = 5;
            this.buttonClientData.Text = "Ügyfelek adatai";
            this.buttonClientData.UseVisualStyleBackColor = true;
            this.buttonClientData.Click += new System.EventHandler(this.buttonClientData_Click);
            // 
            // buttonDoneWork
            // 
            this.buttonDoneWork.FlatAppearance.BorderSize = 0;
            this.buttonDoneWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoneWork.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDoneWork.ForeColor = System.Drawing.Color.White;
            this.buttonDoneWork.Location = new System.Drawing.Point(0, 180);
            this.buttonDoneWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDoneWork.Name = "buttonDoneWork";
            this.buttonDoneWork.Size = new System.Drawing.Size(202, 86);
            this.buttonDoneWork.TabIndex = 4;
            this.buttonDoneWork.Text = "Elvégzett munkálatok";
            this.buttonDoneWork.UseVisualStyleBackColor = true;
            this.buttonDoneWork.Click += new System.EventHandler(this.buttonDoneWork_Click);
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
            this.buttonNewWork.Text = "Új munkálatok";
            this.buttonNewWork.UseVisualStyleBackColor = true;
            this.buttonNewWork.Click += new System.EventHandler(this.buttonNewWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Önnek ";
            // 
            // labelNewWorkNumber
            // 
            this.labelNewWorkNumber.AutoSize = true;
            this.labelNewWorkNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewWorkNumber.ForeColor = System.Drawing.Color.Red;
            this.labelNewWorkNumber.Location = new System.Drawing.Point(98, 15);
            this.labelNewWorkNumber.Name = "labelNewWorkNumber";
            this.labelNewWorkNumber.Size = new System.Drawing.Size(49, 21);
            this.labelNewWorkNumber.TabIndex = 4;
            this.labelNewWorkNumber.Text = "szam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(143, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "függőben lévő munkája van";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 521);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // userControlWorkerClientData1
            // 
            this.userControlWorkerClientData1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlWorkerClientData1.Location = new System.Drawing.Point(201, 80);
            this.userControlWorkerClientData1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlWorkerClientData1.Name = "userControlWorkerClientData1";
            this.userControlWorkerClientData1.Size = new System.Drawing.Size(1062, 601);
            this.userControlWorkerClientData1.TabIndex = 9;
            // 
            // userControlCompleteWorks1
            // 
            this.userControlCompleteWorks1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlCompleteWorks1.Location = new System.Drawing.Point(202, 80);
            this.userControlCompleteWorks1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlCompleteWorks1.Name = "userControlCompleteWorks1";
            this.userControlCompleteWorks1.Size = new System.Drawing.Size(1062, 602);
            this.userControlCompleteWorks1.TabIndex = 8;
            // 
            // userControlNewWorks1
            // 
            this.userControlNewWorks1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlNewWorks1.Location = new System.Drawing.Point(202, 80);
            this.userControlNewWorks1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlNewWorks1.Name = "userControlNewWorks1";
            this.userControlNewWorks1.Size = new System.Drawing.Size(1062, 601);
            this.userControlNewWorks1.TabIndex = 7;
            // 
            // panelIsWork
            // 
            this.panelIsWork.Controls.Add(this.label3);
            this.panelIsWork.Controls.Add(this.label1);
            this.panelIsWork.Controls.Add(this.labelNewWorkNumber);
            this.panelIsWork.Location = new System.Drawing.Point(220, 98);
            this.panelIsWork.Name = "panelIsWork";
            this.panelIsWork.Size = new System.Drawing.Size(445, 46);
            this.panelIsWork.TabIndex = 10;
            // 
            // panelNoWork
            // 
            this.panelNoWork.Controls.Add(this.label2);
            this.panelNoWork.Location = new System.Drawing.Point(723, 98);
            this.panelNoWork.Name = "panelNoWork";
            this.panelNoWork.Size = new System.Drawing.Size(367, 46);
            this.panelNoWork.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Önnek nincs függőben lévő munkája";
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.userControlWorkerClientData1);
            this.Controls.Add(this.userControlCompleteWorks1);
            this.Controls.Add(this.userControlNewWorks1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelIsWork);
            this.Controls.Add(this.panelNoWork);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWorker";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelIsWork.ResumeLayout(false);
            this.panelIsWork.PerformLayout();
            this.panelNoWork.ResumeLayout(false);
            this.panelNoWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonClientData;
        private System.Windows.Forms.Button buttonDoneWork;
        private System.Windows.Forms.Button buttonNewWork;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNewWorkNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelSign;
        private UserControlNewWorks userControlNewWorks1;
        private UserControlWorkerCompleteWorks userControlCompleteWorks1;
        private UserControlWorkerClientData userControlWorkerClientData1;
        private System.Windows.Forms.Panel panelIsWork;
        private System.Windows.Forms.Panel panelNoWork;
        private System.Windows.Forms.Label label2;
    }
}