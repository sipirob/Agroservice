﻿namespace Agroservice.View
{
    partial class UserControlLeaderSettings
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
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteService = new System.Windows.Forms.Button();
            this.buttonUpdateService = new System.Windows.Forms.Button();
            this.buttonNewService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxServices
            // 
            this.listBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 21;
            this.listBoxServices.Location = new System.Drawing.Point(50, 40);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(237, 445);
            this.listBoxServices.TabIndex = 0;
            this.listBoxServices.SelectedIndexChanged += new System.EventHandler(this.listBoxServices_SelectedIndexChanged);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(463, 40);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(173, 27);
            this.textBoxServiceName.TabIndex = 1;
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(461, 124);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(173, 27);
            this.textBoxServicePrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szolgáltatás neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szolgáltatás ára";
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.Location = new System.Drawing.Point(844, 40);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(119, 56);
            this.buttonDeleteService.TabIndex = 5;
            this.buttonDeleteService.Text = "Törlés";
            this.buttonDeleteService.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateService
            // 
            this.buttonUpdateService.Location = new System.Drawing.Point(844, 130);
            this.buttonUpdateService.Name = "buttonUpdateService";
            this.buttonUpdateService.Size = new System.Drawing.Size(119, 56);
            this.buttonUpdateService.TabIndex = 6;
            this.buttonUpdateService.Text = "Módosít";
            this.buttonUpdateService.UseVisualStyleBackColor = true;
            // 
            // buttonNewService
            // 
            this.buttonNewService.Location = new System.Drawing.Point(844, 219);
            this.buttonNewService.Name = "buttonNewService";
            this.buttonNewService.Size = new System.Drawing.Size(119, 56);
            this.buttonNewService.TabIndex = 7;
            this.buttonNewService.Text = "Új";
            this.buttonNewService.UseVisualStyleBackColor = true;
            // 
            // UserControlLeaderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNewService);
            this.Controls.Add(this.buttonUpdateService);
            this.Controls.Add(this.buttonDeleteService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.listBoxServices);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlLeaderSettings";
            this.Size = new System.Drawing.Size(1062, 612);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteService;
        private System.Windows.Forms.Button buttonUpdateService;
        private System.Windows.Forms.Button buttonNewService;
        public System.Windows.Forms.ListBox listBoxServices;
        public System.Windows.Forms.TextBox textBoxServiceName;
        public System.Windows.Forms.TextBox textBoxServicePrice;
    }
}