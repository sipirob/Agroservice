namespace Agroservice
{
    partial class UserControlNewWorks
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gMapControlParcelMap = new GMap.NET.WindowsForms.GMapControl();
            this.listViewNewWork = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRoute = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1109, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "m2";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(581, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Elvégezve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gMapControlParcelMap
            // 
            this.gMapControlParcelMap.Bearing = 0F;
            this.gMapControlParcelMap.CanDragMap = true;
            this.gMapControlParcelMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlParcelMap.GrayScaleMode = false;
            this.gMapControlParcelMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlParcelMap.LevelsKeepInMemmory = 5;
            this.gMapControlParcelMap.Location = new System.Drawing.Point(581, 4);
            this.gMapControlParcelMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gMapControlParcelMap.MarkersEnabled = true;
            this.gMapControlParcelMap.MaxZoom = 2;
            this.gMapControlParcelMap.MinZoom = 2;
            this.gMapControlParcelMap.MouseWheelZoomEnabled = true;
            this.gMapControlParcelMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlParcelMap.Name = "gMapControlParcelMap";
            this.gMapControlParcelMap.NegativeMode = false;
            this.gMapControlParcelMap.PolygonsEnabled = true;
            this.gMapControlParcelMap.RetryLoadTile = 0;
            this.gMapControlParcelMap.RoutesEnabled = true;
            this.gMapControlParcelMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlParcelMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlParcelMap.ShowTileGridLines = false;
            this.gMapControlParcelMap.Size = new System.Drawing.Size(478, 518);
            this.gMapControlParcelMap.TabIndex = 22;
            this.gMapControlParcelMap.Zoom = 0D;
            // 
            // listViewNewWork
            // 
            this.listViewNewWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listViewNewWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewNewWork.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewNewWork.FullRowSelect = true;
            this.listViewNewWork.GridLines = true;
            this.listViewNewWork.Location = new System.Drawing.Point(0, 0);
            this.listViewNewWork.Name = "listViewNewWork";
            this.listViewNewWork.Size = new System.Drawing.Size(575, 597);
            this.listViewNewWork.TabIndex = 23;
            this.listViewNewWork.UseCompatibleStateImageBehavior = false;
            this.listViewNewWork.View = System.Windows.Forms.View.Details;
            this.listViewNewWork.SelectedIndexChanged += new System.EventHandler(this.listViewNewWork_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "dátum";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "parcellaszám";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "munkálat neve";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "vetemény";
            this.columnHeader4.Width = 120;
            // 
            // buttonRoute
            // 
            this.buttonRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRoute.Location = new System.Drawing.Point(698, 564);
            this.buttonRoute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(99, 33);
            this.buttonRoute.TabIndex = 24;
            this.buttonRoute.Text = "Útvonal";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalc.Location = new System.Drawing.Point(803, 564);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(111, 33);
            this.buttonCalc.TabIndex = 27;
            this.buttonCalc.Text = "Kalkulátor";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDistance.Location = new System.Drawing.Point(581, 526);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(0, 21);
            this.labelDistance.TabIndex = 28;
            // 
            // UserControlNewWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonRoute);
            this.Controls.Add(this.listViewNewWork);
            this.Controls.Add(this.gMapControlParcelMap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlNewWorks";
            this.Size = new System.Drawing.Size(1062, 612);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listViewNewWork;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public GMap.NET.WindowsForms.GMapControl gMapControlParcelMap;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelDistance;
    }
}
