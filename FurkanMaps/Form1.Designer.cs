namespace FurkanMaps.Model
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnVeriGetir = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnTahminiHavaDurumu = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(20, 60);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
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
            this.gMapControl1.Size = new System.Drawing.Size(1201, 422);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // btnVeriGetir
            // 
            this.btnVeriGetir.Location = new System.Drawing.Point(23, 489);
            this.btnVeriGetir.Name = "btnVeriGetir";
            this.btnVeriGetir.Size = new System.Drawing.Size(251, 23);
            this.btnVeriGetir.TabIndex = 1;
            this.btnVeriGetir.Text = "Bir Gün Öncesine Ait Hava Durumu Verisi Al";
            this.btnVeriGetir.UseSelectable = true;
            this.btnVeriGetir.Click += new System.EventHandler(this.btnVeriGetir_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 518);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(251, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Anlık Hava Durumu Bilgisi Al";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(280, 489);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Son Veri Alınma Zamanı:";
            // 
            // btnTahminiHavaDurumu
            // 
            this.btnTahminiHavaDurumu.Location = new System.Drawing.Point(23, 547);
            this.btnTahminiHavaDurumu.Name = "btnTahminiHavaDurumu";
            this.btnTahminiHavaDurumu.Size = new System.Drawing.Size(251, 23);
            this.btnTahminiHavaDurumu.TabIndex = 4;
            this.btnTahminiHavaDurumu.Text = "Tahmin Verisi Getir";
            this.btnTahminiHavaDurumu.UseSelectable = true;
            this.btnTahminiHavaDurumu.Click += new System.EventHandler(this.btnTahminiHavaDurumu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1241, 649);
            this.Controls.Add(this.btnTahminiHavaDurumu);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnVeriGetir);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Türkiye Hava Durumu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private MetroFramework.Controls.MetroButton btnVeriGetir;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnTahminiHavaDurumu;
    }
}