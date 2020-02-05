namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapPrincipal = new GMap.NET.WindowsForms.GMapControl();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.gMapControl3 = new GMap.NET.WindowsForms.GMapControl();
            this.gMapControl4 = new GMap.NET.WindowsForms.GMapControl();
            this.bntLoad = new System.Windows.Forms.Button();
            this.cmbCriterion1 = new System.Windows.Forms.ComboBox();
            this.cmbCriterion2 = new System.Windows.Forms.ComboBox();
            this.cmbCriterion3 = new System.Windows.Forms.ComboBox();
            this.cmbCriterion1Select = new System.Windows.Forms.ComboBox();
            this.cmbCriterion2Select = new System.Windows.Forms.ComboBox();
            this.cmbCriterion3Select = new System.Windows.Forms.ComboBox();
            this.cmbGMap1 = new System.Windows.Forms.ComboBox();
            this.cmbGMap3 = new System.Windows.Forms.ComboBox();
            this.cmbGMap2 = new System.Windows.Forms.ComboBox();
            this.cmbGMap4 = new System.Windows.Forms.ComboBox();
            this.cmbPrincipal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gMapPrincipal
            // 
            this.gMapPrincipal.Bearing = 0F;
            this.gMapPrincipal.CanDragMap = true;
            this.gMapPrincipal.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapPrincipal.GrayScaleMode = false;
            this.gMapPrincipal.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapPrincipal.LevelsKeepInMemory = 5;
            this.gMapPrincipal.Location = new System.Drawing.Point(12, 353);
            this.gMapPrincipal.MarkersEnabled = true;
            this.gMapPrincipal.MaxZoom = 18;
            this.gMapPrincipal.MinZoom = 2;
            this.gMapPrincipal.MouseWheelZoomEnabled = true;
            this.gMapPrincipal.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapPrincipal.Name = "gMapPrincipal";
            this.gMapPrincipal.NegativeMode = false;
            this.gMapPrincipal.PolygonsEnabled = true;
            this.gMapPrincipal.RetryLoadTile = 0;
            this.gMapPrincipal.RoutesEnabled = true;
            this.gMapPrincipal.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapPrincipal.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapPrincipal.ShowTileGridLines = false;
            this.gMapPrincipal.Size = new System.Drawing.Size(343, 222);
            this.gMapPrincipal.TabIndex = 0;
            this.gMapPrincipal.Zoom = 3D;
            this.gMapPrincipal.Load += new System.EventHandler(this.gMapPrincipal_Load);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(401, 61);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(343, 222);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 3D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // gMapControl2
            // 
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(794, 61);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 18;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(343, 222);
            this.gMapControl2.TabIndex = 0;
            this.gMapControl2.Zoom = 3D;
            this.gMapControl2.Load += new System.EventHandler(this.gMapControl2_Load);
            // 
            // gMapControl3
            // 
            this.gMapControl3.Bearing = 0F;
            this.gMapControl3.CanDragMap = true;
            this.gMapControl3.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl3.GrayScaleMode = false;
            this.gMapControl3.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl3.LevelsKeepInMemory = 5;
            this.gMapControl3.Location = new System.Drawing.Point(401, 353);
            this.gMapControl3.MarkersEnabled = true;
            this.gMapControl3.MaxZoom = 18;
            this.gMapControl3.MinZoom = 2;
            this.gMapControl3.MouseWheelZoomEnabled = true;
            this.gMapControl3.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl3.Name = "gMapControl3";
            this.gMapControl3.NegativeMode = false;
            this.gMapControl3.PolygonsEnabled = true;
            this.gMapControl3.RetryLoadTile = 0;
            this.gMapControl3.RoutesEnabled = true;
            this.gMapControl3.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl3.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl3.ShowTileGridLines = false;
            this.gMapControl3.Size = new System.Drawing.Size(343, 222);
            this.gMapControl3.TabIndex = 0;
            this.gMapControl3.Zoom = 3D;
            this.gMapControl3.Load += new System.EventHandler(this.gMapControl3_Load);
            // 
            // gMapControl4
            // 
            this.gMapControl4.Bearing = 0F;
            this.gMapControl4.CanDragMap = true;
            this.gMapControl4.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl4.GrayScaleMode = false;
            this.gMapControl4.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl4.LevelsKeepInMemory = 5;
            this.gMapControl4.Location = new System.Drawing.Point(794, 353);
            this.gMapControl4.MarkersEnabled = true;
            this.gMapControl4.MaxZoom = 18;
            this.gMapControl4.MinZoom = 2;
            this.gMapControl4.MouseWheelZoomEnabled = true;
            this.gMapControl4.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl4.Name = "gMapControl4";
            this.gMapControl4.NegativeMode = false;
            this.gMapControl4.PolygonsEnabled = true;
            this.gMapControl4.RetryLoadTile = 0;
            this.gMapControl4.RoutesEnabled = true;
            this.gMapControl4.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl4.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl4.ShowTileGridLines = false;
            this.gMapControl4.Size = new System.Drawing.Size(343, 222);
            this.gMapControl4.TabIndex = 0;
            this.gMapControl4.Zoom = 3D;
            this.gMapControl4.Load += new System.EventHandler(this.gMapControl4_Load);
            // 
            // bntLoad
            // 
            this.bntLoad.Location = new System.Drawing.Point(145, 275);
            this.bntLoad.Name = "bntLoad";
            this.bntLoad.Size = new System.Drawing.Size(75, 23);
            this.bntLoad.TabIndex = 10;
            this.bntLoad.Text = "Mostrar";
            this.bntLoad.UseVisualStyleBackColor = true;
            this.bntLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCriterion1
            // 
            this.cmbCriterion1.FormatString = "Criterio de busqueda";
            this.cmbCriterion1.FormattingEnabled = true;
            this.cmbCriterion1.Location = new System.Drawing.Point(35, 61);
            this.cmbCriterion1.Name = "cmbCriterion1";
            this.cmbCriterion1.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterion1.TabIndex = 11;
            this.cmbCriterion1.SelectedIndexChanged += new System.EventHandler(this.cmbCriterion1_SelectedIndexChanged);
            // 
            // cmbCriterion2
            // 
            this.cmbCriterion2.FormatString = "Criterio de busqueda";
            this.cmbCriterion2.FormattingEnabled = true;
            this.cmbCriterion2.Location = new System.Drawing.Point(35, 110);
            this.cmbCriterion2.Name = "cmbCriterion2";
            this.cmbCriterion2.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterion2.TabIndex = 12;
            this.cmbCriterion2.SelectedIndexChanged += new System.EventHandler(this.cmbCriterion2_SelectedIndexChanged);
            // 
            // cmbCriterion3
            // 
            this.cmbCriterion3.FormatString = "Criterio de busqueda";
            this.cmbCriterion3.FormattingEnabled = true;
            this.cmbCriterion3.Location = new System.Drawing.Point(35, 162);
            this.cmbCriterion3.Name = "cmbCriterion3";
            this.cmbCriterion3.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterion3.TabIndex = 13;
            this.cmbCriterion3.SelectedIndexChanged += new System.EventHandler(this.cmbCriterion3_SelectedIndexChanged);
            // 
            // cmbCriterion1Select
            // 
            this.cmbCriterion1Select.FormattingEnabled = true;
            this.cmbCriterion1Select.Location = new System.Drawing.Point(201, 61);
            this.cmbCriterion1Select.Name = "cmbCriterion1Select";
            this.cmbCriterion1Select.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterion1Select.TabIndex = 15;
            // 
            // cmbCriterion2Select
            // 
            this.cmbCriterion2Select.FormattingEnabled = true;
            this.cmbCriterion2Select.Location = new System.Drawing.Point(201, 110);
            this.cmbCriterion2Select.Name = "cmbCriterion2Select";
            this.cmbCriterion2Select.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterion2Select.TabIndex = 17;
            // 
            // cmbCriterion3Select
            // 
            this.cmbCriterion3Select.FormattingEnabled = true;
            this.cmbCriterion3Select.Location = new System.Drawing.Point(201, 162);
            this.cmbCriterion3Select.Name = "cmbCriterion3Select";
            this.cmbCriterion3Select.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterion3Select.TabIndex = 18;
            // 
            // cmbGMap1
            // 
            this.cmbGMap1.FormattingEnabled = true;
            this.cmbGMap1.Location = new System.Drawing.Point(516, 22);
            this.cmbGMap1.Name = "cmbGMap1";
            this.cmbGMap1.Size = new System.Drawing.Size(121, 21);
            this.cmbGMap1.TabIndex = 19;
            // 
            // cmbGMap3
            // 
            this.cmbGMap3.FormattingEnabled = true;
            this.cmbGMap3.Location = new System.Drawing.Point(516, 310);
            this.cmbGMap3.Name = "cmbGMap3";
            this.cmbGMap3.Size = new System.Drawing.Size(121, 21);
            this.cmbGMap3.TabIndex = 20;
            // 
            // cmbGMap2
            // 
            this.cmbGMap2.FormattingEnabled = true;
            this.cmbGMap2.Location = new System.Drawing.Point(910, 22);
            this.cmbGMap2.Name = "cmbGMap2";
            this.cmbGMap2.Size = new System.Drawing.Size(121, 21);
            this.cmbGMap2.TabIndex = 21;
            // 
            // cmbGMap4
            // 
            this.cmbGMap4.FormattingEnabled = true;
            this.cmbGMap4.Location = new System.Drawing.Point(910, 307);
            this.cmbGMap4.Name = "cmbGMap4";
            this.cmbGMap4.Size = new System.Drawing.Size(121, 21);
            this.cmbGMap4.TabIndex = 22;
            // 
            // cmbPrincipal
            // 
            this.cmbPrincipal.FormattingEnabled = true;
            this.cmbPrincipal.Location = new System.Drawing.Point(120, 310);
            this.cmbPrincipal.Name = "cmbPrincipal";
            this.cmbPrincipal.Size = new System.Drawing.Size(121, 21);
            this.cmbPrincipal.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1157, 587);
            this.Controls.Add(this.cmbPrincipal);
            this.Controls.Add(this.cmbGMap4);
            this.Controls.Add(this.cmbGMap2);
            this.Controls.Add(this.cmbGMap3);
            this.Controls.Add(this.cmbGMap1);
            this.Controls.Add(this.cmbCriterion3Select);
            this.Controls.Add(this.cmbCriterion2Select);
            this.Controls.Add(this.cmbCriterion1Select);
            this.Controls.Add(this.cmbCriterion3);
            this.Controls.Add(this.cmbCriterion2);
            this.Controls.Add(this.cmbCriterion1);
            this.Controls.Add(this.bntLoad);
            this.Controls.Add(this.gMapControl4);
            this.Controls.Add(this.gMapControl3);
            this.Controls.Add(this.gMapControl2);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.gMapPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapPrincipal;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private GMap.NET.WindowsForms.GMapControl gMapControl3;
        private GMap.NET.WindowsForms.GMapControl gMapControl4;
        private System.Windows.Forms.Button bntLoad;
        private System.Windows.Forms.ComboBox cmbCriterion1;
        private System.Windows.Forms.ComboBox cmbCriterion2;
        private System.Windows.Forms.ComboBox cmbCriterion3;
        private System.Windows.Forms.ComboBox cmbCriterion1Select;
        private System.Windows.Forms.ComboBox cmbCriterion2Select;
        private System.Windows.Forms.ComboBox cmbCriterion3Select;
        private System.Windows.Forms.ComboBox cmbGMap1;
        private System.Windows.Forms.ComboBox cmbGMap3;
        private System.Windows.Forms.ComboBox cmbGMap2;
        private System.Windows.Forms.ComboBox cmbGMap4;
        private System.Windows.Forms.ComboBox cmbPrincipal;
    }
}

