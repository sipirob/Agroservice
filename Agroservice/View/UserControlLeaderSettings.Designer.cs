namespace Agroservice.View
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
            this.components = new System.ComponentModel.Container();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteService = new System.Windows.Forms.Button();
            this.buttonUpdateService = new System.Windows.Forms.Button();
            this.buttonNewService = new System.Windows.Forms.Button();
            this.buttonSaveService = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderServiePrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderServiePrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxServices
            // 
            this.listBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 21;
            this.listBoxServices.Location = new System.Drawing.Point(3, 3);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(299, 613);
            this.listBoxServices.TabIndex = 0;
            this.listBoxServices.SelectedIndexChanged += new System.EventHandler(this.listBoxServices_SelectedIndexChanged);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(494, 23);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(302, 27);
            this.textBoxServiceName.TabIndex = 1;
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(494, 108);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(304, 27);
            this.textBoxServicePrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szolgáltatás neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szolgáltatás ára:";
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.FlatAppearance.BorderSize = 0;
            this.buttonDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteService.Location = new System.Drawing.Point(3, 3);
            this.buttonDeleteService.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(197, 73);
            this.buttonDeleteService.TabIndex = 5;
            this.buttonDeleteService.Text = "Törlés";
            this.buttonDeleteService.UseVisualStyleBackColor = true;
            this.buttonDeleteService.Click += new System.EventHandler(this.buttonDeleteService_Click);
            // 
            // buttonUpdateService
            // 
            this.buttonUpdateService.FlatAppearance.BorderSize = 0;
            this.buttonUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateService.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdateService.Location = new System.Drawing.Point(3, 79);
            this.buttonUpdateService.Name = "buttonUpdateService";
            this.buttonUpdateService.Size = new System.Drawing.Size(194, 56);
            this.buttonUpdateService.TabIndex = 6;
            this.buttonUpdateService.Text = "Módosít";
            this.buttonUpdateService.UseVisualStyleBackColor = true;
            this.buttonUpdateService.Click += new System.EventHandler(this.buttonUpdateService_Click);
            // 
            // buttonNewService
            // 
            this.buttonNewService.FlatAppearance.BorderSize = 0;
            this.buttonNewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewService.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonNewService.Location = new System.Drawing.Point(3, 141);
            this.buttonNewService.Name = "buttonNewService";
            this.buttonNewService.Size = new System.Drawing.Size(194, 56);
            this.buttonNewService.TabIndex = 7;
            this.buttonNewService.Text = "Új";
            this.buttonNewService.UseVisualStyleBackColor = true;
            this.buttonNewService.Click += new System.EventHandler(this.buttonNewService_Click);
            // 
            // buttonSaveService
            // 
            this.buttonSaveService.FlatAppearance.BorderSize = 0;
            this.buttonSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveService.Location = new System.Drawing.Point(3, 553);
            this.buttonSaveService.Name = "buttonSaveService";
            this.buttonSaveService.Size = new System.Drawing.Size(194, 56);
            this.buttonSaveService.TabIndex = 8;
            this.buttonSaveService.Text = "Mentés";
            this.buttonSaveService.UseVisualStyleBackColor = true;
            this.buttonSaveService.Click += new System.EventHandler(this.buttonSaveService_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(3, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(194, 56);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProviderServiePrice
            // 
            this.errorProviderServiePrice.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonDeleteService);
            this.panel1.Controls.Add(this.buttonSaveService);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonUpdateService);
            this.panel1.Controls.Add(this.buttonNewService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(862, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 612);
            this.panel1.TabIndex = 10;
            // 
            // UserControlLeaderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.listBoxServices);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlLeaderSettings";
            this.Size = new System.Drawing.Size(1062, 612);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderServiePrice)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonSaveService;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProviderServiePrice;
        private System.Windows.Forms.Panel panel1;
    }
}
