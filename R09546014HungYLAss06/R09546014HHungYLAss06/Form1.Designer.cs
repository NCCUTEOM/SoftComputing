namespace R09546014HungYLAss06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 40;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Zoom = 88;
            this.tChart1.Aspect.ZoomFloat = 88D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            this.tChart1.Series.Add(this.surface1);
            this.tChart1.Size = new System.Drawing.Size(800, 450);
            this.tChart1.TabIndex = 0;
            this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
            // 
            // chartController1
            // 
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 0);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(800, 38);
            this.chartController1.TabIndex = 1;
            this.chartController1.Text = "chartController1";
            this.chartController1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.chartController1_ItemClicked);
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.ColorEach = false;
            this.surface1.PaletteMin = 0D;
            this.surface1.PaletteStep = 0D;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.surface1.Title = "ResponseSurface";
            // 
            // 
            // 
            this.surface1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.surface1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.surface1.ZValues.DataMember = "Z";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartController1);
            this.Controls.Add(this.tChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.ChartController chartController1;
        private Steema.TeeChart.Styles.Surface surface1;
        private System.Windows.Forms.Button button1;
    }
}