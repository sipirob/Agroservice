﻿namespace Agroservice
{
    partial class UserControlWorkerCompleteWorks
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
            this.dataGridViewCompleteWorks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompleteWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompleteWorks
            // 
            this.dataGridViewCompleteWorks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCompleteWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompleteWorks.Location = new System.Drawing.Point(39, 95);
            this.dataGridViewCompleteWorks.Name = "dataGridViewCompleteWorks";
            this.dataGridViewCompleteWorks.Size = new System.Drawing.Size(970, 467);
            this.dataGridViewCompleteWorks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elvégzett munkálatok adatai:";
            // 
            // UserControlCompleteWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCompleteWorks);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlCompleteWorks";
            this.Size = new System.Drawing.Size(1062, 617);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompleteWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewCompleteWorks;
    }
}
