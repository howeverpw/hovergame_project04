namespace GPSTest3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.LatText = new System.Windows.Forms.TextBox();
            this.LongText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RangeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GPSOutputText = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gmap.CanDragMap = false;
            this.gmap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(23, 24);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 3;
            this.gmap.MouseWheelZoomEnabled = false;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1366, 959);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1412, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(470, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set Position (GPS)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LatText
            // 
            this.LatText.Location = new System.Drawing.Point(1412, 153);
            this.LatText.Name = "LatText";
            this.LatText.Size = new System.Drawing.Size(220, 31);
            this.LatText.TabIndex = 2;
            this.LatText.Text = "37.8651";
            // 
            // LongText
            // 
            this.LongText.Location = new System.Drawing.Point(1662, 153);
            this.LongText.Name = "LongText";
            this.LongText.Size = new System.Drawing.Size(220, 31);
            this.LongText.TabIndex = 3;
            this.LongText.Text = "-119.5383";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1412, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "GPS Lat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1657, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "GPS Long";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1412, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zoom Radius (m)";
            // 
            // RangeText
            // 
            this.RangeText.Location = new System.Drawing.Point(1412, 323);
            this.RangeText.Name = "RangeText";
            this.RangeText.Size = new System.Drawing.Size(145, 31);
            this.RangeText.TabIndex = 6;
            this.RangeText.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(1552, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Controls";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1412, 916);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(470, 67);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear Waypoints";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GPSOutputText
            // 
            this.GPSOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPSOutputText.Location = new System.Drawing.Point(1412, 614);
            this.GPSOutputText.Name = "GPSOutputText";
            this.GPSOutputText.Size = new System.Drawing.Size(470, 296);
            this.GPSOutputText.TabIndex = 18;
            this.GPSOutputText.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(1651, 292);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(231, 67);
            this.GenerateButton.TabIndex = 19;
            this.GenerateButton.Text = "Generate Zone";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.ZoneButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1412, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Beacon Radius (m)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1412, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 31);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "750";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.GPSOutputText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RangeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LongText);
            this.Controls.Add(this.LatText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "HoverGames GPS Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LatText;
        private System.Windows.Forms.TextBox LongText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RangeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox GPSOutputText;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

